using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Rimworld.Models
{
    public class StockPie
    {

        public static List<string[]> getList()
        {
            List<string[]> lstStockPie = new List<string[]>();

            string fileContents = Common.cache["filecontents"] as string;
            if (fileContents == null) return lstStockPie;

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(fileContents);
            XmlElement root = xmlDoc.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("//savegame/game");

            XmlNodeList thingsNode = nodes[0].SelectNodes("maps/li/zoneManager/allZones/li[@Class='Zone_Stockpile']");
           
            foreach (XmlNode thingNode in thingsNode)
            {                
                string name = Common.getValueFromNode(thingNode, "label");            
                string color = Common.getValueFromNode(thingNode, "color");
                color = color.Replace("RGBA(", "");
                color = color.Replace(")", "");
                //string[] colors = color.Split(',');
                //Color _color = Color.FromArgb(int.Parse(colors[0]), int.Parse(colors[1]), int.Parse(colors[2]), int.Parse(colors[3]));
                lstStockPie.Add(new string[] { name, color });

            }

            return lstStockPie;
        }

        public static void showDataGirdView(DataGridView dgv_ListStockPie)
        {
            dgv_ListStockPie.Rows.Clear();
            List<string[]> listData = StockPie.getList();
            listData.ForEach(d => dgv_ListStockPie.Rows.Add(d));

            int count = 0;
            foreach (DataGridViewRow row in dgv_ListStockPie.Rows) {
                string[] colors = listData[count][1].Split(',');
                int R = Int32.Parse( (float.Parse(colors[0]) * 100).ToString());
                int G = Int32.Parse( (float.Parse(colors[1]) * 100).ToString());
                int B = Int32.Parse( (float.Parse(colors[2]) * 100).ToString());
                int A = Int32.Parse( Math.Round(float.Parse(colors[3]) * 10).ToString());
                Color _color = Color.FromArgb(R, G, B);
                row.DefaultCellStyle.BackColor = _color;                
                count++;
            }
            

            Common.addButtonToDataGirdView(dgv_ListStockPie, "btn_show_items", "Show Items");
        }
    }
}
