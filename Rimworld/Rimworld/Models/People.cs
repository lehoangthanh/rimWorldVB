using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;
using System.Xml;
using System.Windows.Forms;
using System.IO;

namespace Rimworld.Models
{
    public class People
    {
        //private static ObjectCache cache = MemoryCache.Default;

        private string _id, _firstName, _lastName, _fullName, _nick, _kindDef;

        public string id{
            get { return this._id; }
            set{ this._id = value; }           
        }

        public string fullname
        {
            get { return this._firstName+ ' '+ this._lastName; }
            set { this._fullName = value; }
        }

        public string firstName
        {
            get { return this._firstName; }
            set { this._firstName = value; }
        }

        public string lastName
        {
            get { return this._lastName; }
            set { this._lastName = value; }
        }

        public string nick
        {
            get { return this._nick; }
            set { this._nick = value; }
        }

        public string kindDef
        {
            get { return this._kindDef; }
            set { this._kindDef = value; }
        }


        public People()
        {

        }

        public static List<People> getListPeople()
        {
            string fileContents = Common.cache["filecontents"] as string;
            //thing
            List<People> listPeople = new List<People>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(fileContents);
            XmlElement root = xmlDoc.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("//savegame/game");

            XmlNodeList thingsNode = nodes[0].SelectNodes("maps/li/things/thing[@Class='Pawn']");
            foreach(XmlNode thingNode in thingsNode)
            {
                People people = new People();


                string def = Common.getValueFromNode(thingNode, "def");
                if (def != "Human") continue;
                
                string id = Common.getValueFromNode(thingNode, "id");
                string kindDef = Common.getValueFromNode(thingNode, "kindDef");

                XmlNode NameTriple = thingNode.SelectSingleNode("name");
                string firstName = Common.getValueFromNode(NameTriple, "first");
                string lastName = Common.getValueFromNode(NameTriple, "last");                
                string nickName = Common.getValueFromNode(NameTriple, "nick");

                people.id = id;
                people.firstName = firstName;
                people.lastName = lastName;               
                people.nick = nickName;
                people.kindDef = kindDef;
                listPeople.Add(people);

            }

            return listPeople;
                
        }

        internal static void showDataGirdView(object dgv_ListPeople)
        {
            throw new NotImplementedException();
        }

        public static ListView getListPeopleForListView(List<People> listPeople)
        {
            ListView lvPeople = new ListView();
            
            lvPeople.Items.AddRange(listPeople.Select(p => new ListViewItem(new string[] { p.id, p.fullname, p.nick, p.kindDef})).ToArray());
            return lvPeople;
        }
       

        public static void showListView(ListView listView_People)
        {
            listView_People.Visible = true;
            List<People> listPeople = People.getListPeople();
            ListView lvPeople = People.getListPeopleForListView(listPeople);
            listView_People.Items.Clear();
            listView_People.Items.AddRange((from ListViewItem item in lvPeople.Items
                                            select (ListViewItem)item.Clone()
                   ).ToArray());
            listView_People.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public static void showDataGirdView(DataGridView dgv_ListPeople)
        {            
            dgv_ListPeople.Rows.Clear();            
            List<People> listPeople = People.getListPeople();
            listPeople.ForEach(p => dgv_ListPeople.Rows.Add(new string[]{ p.id, p.fullname, p.nick, p.kindDef }));
            People.addButtonToDataGirdView(dgv_ListPeople, "btn_delete", "Delete");
        }

        public static void addButtonToDataGirdView(DataGridView dgv_ListPeople, string btnName, string btnText)
        {
            DataGridViewColumn col = dgv_ListPeople.Columns[btnName];
            if (col != null) return;

            var btn = new DataGridViewButtonColumn();
            btn.Name = btnName;
            btn.HeaderText = btnText;
            btn.Text = btnText;
            btn.UseColumnTextForButtonValue = true;
            dgv_ListPeople.Columns.Add(btn);

        }


        public static string delete(DataGridViewRow row, DataGridView dgv_ListPeople)
        {
            
            DataGridViewCell idCell = (DataGridViewCell)row.Cells["id"];
            string id = idCell.Value.ToString();

            
            string fileContents = Common.cache["filecontents"] as string;
            //thing
            List<People> listPeople = new List<People>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(fileContents);
            XmlElement root = xmlDoc.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("//savegame/game");

            XmlNodeList thingsNode = nodes[0].SelectNodes("maps/li/things/thing[@Class='Pawn']");
         
            foreach (XmlNode thingNode in thingsNode)
            {
                People people = new People();


                string def = Common.getValueFromNode(thingNode, "def");
                if (def != "Human") continue;

                string idHuman = Common.getValueFromNode(thingNode, "id");
                if(idHuman == id)
                {
                    thingNode.ParentNode.RemoveChild(thingNode);
                }             
            }


            Common.saveFile(xmlDoc);
            People.showDataGirdView(dgv_ListPeople);
            dgv_ListPeople.Refresh();

            return id;


        }


    }
}
