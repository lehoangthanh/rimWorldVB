using Rimworld.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rimworld.Views;
using Rimworld.Presenters;

namespace Rimworld
{
    public partial class StockPieForm : Form, IDashBoard
    {
        private DashboarPrensters dashboarPrensters;

        public string listFilesSave { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public StockPieForm()
        {
            InitializeComponent();
            if (this.dashboarPrensters is null)
            {
                this.dashboarPrensters = new DashboarPrensters(this);
            }
            StockPie.showDataGirdView(dgv_ListStockePie);
            dgv_ListStockePie.CellClick += new DataGridViewCellEventHandler(dgv_ListStockePie_CellContentClick);

        }

        private void btn_Stockpie_Click(object sender, EventArgs e)
        {
            Form frm = this.ActiveMdiChild;
            
            Common.showForm(new StockPieForm(), this.FindForm().Name);
        }

        private void btn_People_Click(object sender, EventArgs e)
        {
            Common.showForm(new Form1(), this.FindForm().Name);
        }

        private void btn_load_file_Click(object sender, EventArgs e)
        {
            Common.showMessage(lbl_result_process, "File Đang xử lý...");
            string fileName = cbx_ListFilesSave.Text;
            string filePath = this.dashboarPrensters.getFileStorePath(fileName);

            Common.loadFile(filePath);


            Common.showMessage(lbl_result_process, "Load File Thành Công...", 2);
        }

        private void reload_Click(object sender, EventArgs e)
        {
            Common.showMessage(lbl_result_process, "Reload Đang xử lý...");
            if (this.dashboarPrensters is null)
            {
                this.dashboarPrensters = new DashboarPrensters(this);
            }
            cbx_ListFilesSave.DataSource = this.dashboarPrensters.showListFilesSave();
            StockPie.showDataGirdView(dgv_ListStockePie);
            dgv_ListStockePie.CellClick += new DataGridViewCellEventHandler(dgv_ListStockePie_CellContentClick);

            Common.showMessage(lbl_result_process, "Reload Thành Công...", 2);
        }

        void dgv_ListStockePie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)dgv_ListStockePie.Rows[e.RowIndex];
            string cellType = row.Cells[e.ColumnIndex].GetType().ToString();
            if (cellType != "System.Windows.Forms.DataGridViewButtonCell") return;
            ItemInStockForm form =new ItemInStockForm();
            
            bool showForm = Application.OpenForms.Cast<Form>().Any(f => (f.Name == form.Name));
            if (!showForm)
            {
                //Common.writeCache('')
                form.Show();
            }


            //Common.showMessage(lbl_result_process, "Đang xử lý...");

            //DataGridViewButtonCell btnCell = (DataGridViewButtonCell)row.Cells[e.ColumnIndex];
            //btnCell.ReadOnly = true;
            //string id = "";
            //string btnAction = btnCell.Value.ToString().ToLower();
            //switch (btnAction)
            //{
            //    case "delete":
            //        {
            //            id = People.delete(row, dgv_ListPeople);
            //            break;
            //        }
            //}

            //Common.showMessage(lbl_result_process, btnAction + " Thành Công...", 5);

        }
    }
}
