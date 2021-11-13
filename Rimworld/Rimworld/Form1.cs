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

        private void reload_Click(object sender, EventArgs e)
        {
            Common.showMessage(lbl_result_process, "Reload Đang xử lý...");
            if (this.dashboarPrensters is null)
            {
                this.dashboarPrensters = new DashboarPrensters(this);
            }
            cbx_ListFilesSave.DataSource = this.dashboarPrensters.showListFilesSave();
            Common.showMessage(lbl_result_process, "Reload Thành Công...",2);
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
            // Add a CellClick handler to handle clicks in the button column.
            dgv_ListPeople.CellClick += new DataGridViewCellEventHandler(dgv_ListPeople_CellClick);

            Common.showMessage(lbl_result_process, "Load File Thành Công...", 2);

        }

        void dgv_ListPeople_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            DataGridViewRow row = (DataGridViewRow)dgv_ListPeople.Rows[e.RowIndex];
            string cellType = row.Cells[e.ColumnIndex].GetType().ToString();
            if(cellType != "System.Windows.Forms.DataGridViewButtonCell") return;
            Common.showMessage(lbl_result_process, "Đang xử lý...");

            DataGridViewButtonCell btnCell = (DataGridViewButtonCell)row.Cells[e.ColumnIndex];
            btnCell.ReadOnly = true;
            string id = "";           
            string btnAction = btnCell.Value.ToString().ToLower();            
            switch (btnAction){
                case "delete":
                    {
                        id = People.delete(row, dgv_ListPeople);
                        break;
                    }
            }
                       
            Common.showMessage(lbl_result_process, btnAction + " Thành Công...", 5);
          
            
        }

        private void button_upSkill(object sender, EventArgs e)
        {
            Common.showMessage(lbl_result_process, "Up Skills Đang xử lý...");
            People.upSkill(dgv_ListPeople);
            Common.showMessage(lbl_result_process, "Up Skills Thành Công...", 4);
        }

        private void btn_kill_the_enemy(object sender, EventArgs e)
        {
            Common.showMessage(lbl_result_process, "Đang xử lý...");
            People.killEnemy(dgv_ListPeople);
            Common.showMessage(lbl_result_process, "Thành Công...", 2);
        }

        private void Btn_resetHealthPeoples(object sender, EventArgs e)
        {
            Common.showMessage(lbl_result_process, "Đang xử lý...");
            People.resetHealth(dgv_ListPeople);
            Common.showMessage(lbl_result_process, "Thành Công...", 2);
        }

        private void listView_People_DrawColumnHeader(object sender,
                                            DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Red, e.Bounds);
            e.ForeColor.Equals(Common.genColor());
            e.DrawText();
        }

        private void btn_Stockpie_Click(object sender, EventArgs e)
        {            
            Common.showForm(new StockPieForm(), this.FindForm().Name);
        }

        private void btn_People_Click(object sender, EventArgs e)
        {
            Common.showForm(new Form1(), this.FindForm().Name);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }       
    }
}
