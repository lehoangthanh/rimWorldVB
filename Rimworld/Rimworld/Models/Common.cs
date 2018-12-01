﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.Caching;

namespace Rimworld.Models
{
    public class Common
    {
        private static ObjectCache cache = MemoryCache.Default;
        public static string[] getFilesSave()
        {
            string[] filesSave = new string[0];
            string storePath = Common.getStorePath();

            if (Directory.Exists(storePath))
            {
                filesSave = Directory.GetFiles(storePath);
                foreach (string file in filesSave)
                {
                    string extension = Path.GetExtension(file);
                    if (extension != ".rws")
                    {
                        filesSave = filesSave.Where(w => w != file).ToArray();                       
                    }
                }

                filesSave = Common.processFilePath(filesSave);
            }
            return filesSave;
        }

        public static string[] processFilePath(string[] filesSave)
        {
            List<string> newFiles = new List<string>();          
            foreach (string filePath in filesSave)
            {
                newFiles.Add(Path.GetFileName(filePath));
            }
            return newFiles.ToArray();
        }

        public static string getStorePath()
        {
            string storePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            storePath += "/../LocalLow/Ludeon Studios/RimWorld by Ludeon Studios/Saves/";
            return storePath;
        }

        public static bool upResearch()
        {
            try
            {
                string filePath = Common.cache["filecontentsPath"] as string;
                string fileContents = Common.cache["filecontents"] as string;
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(fileContents);
                XmlElement root = xmlDoc.DocumentElement;
                XmlNodeList nodes = root.SelectNodes("//savegame/game");

                XmlNode researchManagerNode = nodes[0].SelectSingleNode("researchManager/progress/values");
                foreach (XmlNode li in researchManagerNode.SelectNodes("li"))
                {
                    li.FirstChild.Value = "1000";
                }
                
                Common.loadFile(filePath);
                xmlDoc.Save(filePath);
                return true;

            }catch(Exception ex)
            {
                return false;
            }
        }

       /** public static XmlNodeList getXmlRootNode(string filePath)
        {
            bool fileExits = File.Exists(filePath);
            string fileContent = File.ReadAllText(filePath);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(fileContent);
            XmlElement root = xmlDoc.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("//savegame/game");
            return nodes;
        }*/

        public static string loadFile(string filePath)
        {
            string fileContents = "";
            
            bool fileExits = File.Exists(filePath);
            if (fileExits)
            {
                fileContents = File.ReadAllText(filePath);


                Common.writeCache("filecontents", fileContents);
                Common.writeCache("filecontentsPath", filePath);              
            }
            else
            {
                cache.Remove("filecontents");               
            }
          
            return fileContents;
        }

        public static Color genColor()
        {
            Random rnd = new Random();
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            return randomColor;
        }

        public static void showMessage(Label lbl_result_process, string msg, int timer = 0)
        {           
            lbl_result_process.ForeColor = Common.genColor();
            lbl_result_process.Text = string.Empty;
            lbl_result_process.Text = msg;                  
            lbl_result_process.Invalidate();
            lbl_result_process.Update();
            lbl_result_process.Refresh();
            Application.DoEvents();

            if (timer > 0)
            {
                var t = new Timer();
                t.Interval = timer * 1000; // it will Tick in 3 seconds
                t.Tick += (s, e) =>
                {
                    lbl_result_process.Text = string.Empty;
                    t.Stop();
                };
                t.Start();
            }
        }

        public static void writeCache(string key, string value)
        {
            CacheItemPolicy policy = new CacheItemPolicy();
            policy.AbsoluteExpiration = DateTimeOffset.Now.AddHours(1);

            List<string> filePaths = new List<string>();
            string cachedFilePath = AppDomain.CurrentDomain.BaseDirectory + "cacheText.txt";
            filePaths.Add(cachedFilePath);
            policy.ChangeMonitors.Add(new HostFileChangeMonitor(filePaths));
            cache.Set(key, value, policy);
        }

        public static string getValueFromNode(XmlNode node, string nodeName)
        {
            string value = node.SelectSingleNode(nodeName).FirstChild.Value;
            return value;
        }
    }
}
