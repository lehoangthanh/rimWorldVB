using System;
using System.Collections.Generic;
using System.Data;
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
        private string _name, _color, _cells;

        public string name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        public string color
        {
            get { return this._color; }
            set { this._color = value; }
        }

        public string cells
        {
            get { return this._cells; }
            set { this._cells = value; }
        }

        public static List<string[]> getList()
        {
            List<string[]> lstStockPie = new List<string[]>();

            string fileContents = Common.cache["filecontents"] as string;
            if (fileContents == null) return lstStockPie;

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(fileContents);
            XmlElement root = xmlDoc.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("//savegame/game");

            XmlNodeList thingsNode = nodes[0].SelectNodes("map/zoneManager/allZones/li[@Class='Zone_Stockpile']");
           
            foreach (XmlNode thingNode in thingsNode)
            {                
                string name = Common.getValueFromNode(thingNode, "label");            
                string color = Common.getValueFromNode(thingNode, "color");
                color = color.Replace("RGBA(", "");
                color = color.Replace(")", "");
                //string[] colors = color.Split(',');
                //Color _color = Color.FromArgb(int.Parse(colors[0]), int.Parse(colors[1]), int.Parse(colors[2]), int.Parse(colors[3]));

                // list cells
                string[] cells = thingNode.SelectSingleNode("cells").SelectNodes("li").Cast<XmlNode>().Select(cell => cell.FirstChild.Value).ToArray();

                lstStockPie.Add(new string[] { name, color, string.Join("-",cells) });

            }

            return lstStockPie;
        }

        public static void showDataGirdView(DataGridView dgv_ListStockPie)
        {
            dgv_ListStockPie.Rows.Clear();
            List<string[]> listData = StockPie.getList();

            
            listData.ForEach(d => dgv_ListStockPie.Rows.Add(d));
            Common.addButtonToDataGirdView(dgv_ListStockPie, "btn_show_items", "Show Items");
            int count = 0;
            
            foreach (DataGridViewRow row in dgv_ListStockPie.Rows) {
                if (count > listData.Count()-1) return;
                StockPie stockPie = StockPie.parserArrayToObj(listData[count]);

                
                string[] colors = stockPie.color.Split(',');
                int R = Int16.Parse( (float.Parse(colors[0])).ToString())/10;
                int G = Int16.Parse((float.Parse(colors[1])).ToString()) / 10;
                int B = Int16.Parse((float.Parse(colors[2])).ToString()) / 10;
                int A = Int16.Parse((float.Parse(colors[3])).ToString()) / 10;
                Color _color = Color.FromArgb(R, G, B);
                row.DefaultCellStyle.BackColor = _color;

                string[] cells = stockPie._cells.Split('-');
                int index = row.Index;

                
               
               
                //DataGridView dgv = new DataGridView();
                //dgv.Rows.Add(StockPie.GetTable().Rows);
                DataTable dt = StockPie.GetTable();
            
                int cellCount = 0;
                //cells.Select(cell => dgv_ListStockPie.Columns.Add(new DataGridViewTextBoxColumn()));
                foreach (string cell in cells)
                {
                    int colIndex = 0;
                    cellCount++;
                    if((cellCount+3) > dgv_ListStockPie.ColumnCount)
                    {
                        colIndex = dgv_ListStockPie.Columns.Add(cell,"");
                    }
                    else
                    {
                        colIndex = cellCount;
                    }
                
                    dgv_ListStockPie[colIndex, index].Value = cell;

                }

                //foreach (DataRow dr in dt.Rows)
                //{

                //    dgv_ListStockPie.Rows[row.Index].Add(dr.ItemArray);

                //}

                //row.CreateCells(dgv);

                //cells.Select(cell => row.)
                count++;
            }            
            
        }

        public static DataTable GetTable()
        {
            // Here we create a DataTable with four columns.
            DataTable table = new DataTable();
            table.Columns.Add("Dosage", typeof(int));
            table.Columns.Add("Drug", typeof(string));
            table.Columns.Add("Patient", typeof(string));
            table.Columns.Add("Date", typeof(DateTime));

            // Here we add five DataRows.
            table.Rows.Add(25, "Indocin", "David", DateTime.Now);
            table.Rows.Add(50, "Enebrel", "Sam", DateTime.Now);
            table.Rows.Add(10, "Hydralazine", "Christoff", DateTime.Now);
            table.Rows.Add(21, "Combivent", "Janet", DateTime.Now);
            table.Rows.Add(100, "Dilantin", "Melanie", DateTime.Now);
            return table;
        }

        public static StockPie parserArrayToObj(string[] arr)
        {
            StockPie stockPie = new StockPie();
            stockPie._name = arr[0];
            stockPie._color = arr[1];
            stockPie._cells = arr[2];
            return stockPie;
        }

    }
}
