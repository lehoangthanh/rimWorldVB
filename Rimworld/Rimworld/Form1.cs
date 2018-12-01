using System;
using System.Windows.Forms;
using Rimworld.Views;
using Rimworld.Presenters;
using Rimworld.Models;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
namespace Rimworld
{
    public partial class Form1 : Form, IDashBoard
    {
        private DashboarPrensters dashboarPrensters;
        public Form1()
        {
            InitializeComponent();
            if (this.dashboarPrensters is null)
            {
                this.dashboarPrensters = new DashboarPrensters(this);
            }
            cbx_ListFilesSave.DataSource = this.dashboarPrensters.showListFilesSave();
        }      

        public string listFilesSave
        {
            get
            {
                return cbx_ListFilesSave.Text;
            }
            set
            {
                cbx_ListFilesSave.Text = value;
            }
        }

        private void button_load_file(object sender, EventArgs e)
        {
            Common.showMessage(lbl_result_process, "File Đang xử lý...");
            string fileName = cbx_ListFilesSave.Text;
            string filePath = this.dashboarPrensters.getFileStorePath(fileName);
            
            Common.loadFile(filePath);
                     
            People.showDataGirdView(dgv_ListPeople);
            Common.showMessage(lbl_result_process, "Load File Thành Công...", 2);

        }

        private void button_upSkill(object sender, EventArgs e)
        {
            Common.showMessage(lbl_result_process, "Up Research Đang xử lý...");
           
            bool result = Common.upResearch();
            if (result)
            {
                Common.showMessage(lbl_result_process, "Up Research Thành Công...",2);
            }
        }
        
        private void listView_People_DrawColumnHeader(object sender,
                                            DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Red, e.Bounds);
            e.ForeColor.Equals(Common.genColor());
            e.DrawText();
        }
    }
}
