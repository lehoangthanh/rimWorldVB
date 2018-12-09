namespace Rimworld
{
    partial class StockPieForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_People = new System.Windows.Forms.Button();
            this.btn_Stockpie = new System.Windows.Forms.Button();
            this.reload = new System.Windows.Forms.Button();
            this.btn_load_file = new System.Windows.Forms.Button();
            this.cbx_ListFilesSave = new System.Windows.Forms.ComboBox();
            this.lbl_result_process = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_people = new System.Windows.Forms.Panel();
            this.dgv_ListStockePie = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_People = new System.Windows.Forms.Label();
            this.panel_people.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListStockePie)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_People
            // 
            this.btn_People.Location = new System.Drawing.Point(19, 65);
            this.btn_People.Name = "btn_People";
            this.btn_People.Size = new System.Drawing.Size(97, 26);
            this.btn_People.TabIndex = 16;
            this.btn_People.Text = "People";
            this.btn_People.UseVisualStyleBackColor = true;
            this.btn_People.Click += new System.EventHandler(this.btn_People_Click);
            // 
            // btn_Stockpie
            // 
            this.btn_Stockpie.Location = new System.Drawing.Point(135, 65);
            this.btn_Stockpie.Name = "btn_Stockpie";
            this.btn_Stockpie.Size = new System.Drawing.Size(97, 26);
            this.btn_Stockpie.TabIndex = 15;
            this.btn_Stockpie.Text = "Stock Pie";
            this.btn_Stockpie.UseVisualStyleBackColor = true;
            this.btn_Stockpie.Click += new System.EventHandler(this.btn_Stockpie_Click);
            // 
            // reload
            // 
            this.reload.Location = new System.Drawing.Point(406, 12);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(75, 23);
            this.reload.TabIndex = 14;
            this.reload.Text = "ReLoad";
            this.reload.UseVisualStyleBackColor = true;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // btn_load_file
            // 
            this.btn_load_file.Location = new System.Drawing.Point(325, 12);
            this.btn_load_file.Name = "btn_load_file";
            this.btn_load_file.Size = new System.Drawing.Size(75, 23);
            this.btn_load_file.TabIndex = 13;
            this.btn_load_file.Text = "Load";
            this.btn_load_file.UseVisualStyleBackColor = true;
            this.btn_load_file.Click += new System.EventHandler(this.btn_load_file_Click);
            // 
            // cbx_ListFilesSave
            // 
            this.cbx_ListFilesSave.FormattingEnabled = true;
            this.cbx_ListFilesSave.Location = new System.Drawing.Point(71, 14);
            this.cbx_ListFilesSave.Name = "cbx_ListFilesSave";
            this.cbx_ListFilesSave.Size = new System.Drawing.Size(248, 21);
            this.cbx_ListFilesSave.TabIndex = 12;
            // 
            // lbl_result_process
            // 
            this.lbl_result_process.AutoSize = true;
            this.lbl_result_process.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result_process.Location = new System.Drawing.Point(487, 13);
            this.lbl_result_process.Name = "lbl_result_process";
            this.lbl_result_process.Size = new System.Drawing.Size(147, 22);
            this.lbl_result_process.TabIndex = 11;
            this.lbl_result_process.Text = "Message Results";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "File Save";
            // 
            // panel_people
            // 
            this.panel_people.Controls.Add(this.dgv_ListStockePie);
            this.panel_people.Controls.Add(this.lbl_People);
            this.panel_people.Location = new System.Drawing.Point(2, 98);
            this.panel_people.Name = "panel_people";
            this.panel_people.Size = new System.Drawing.Size(796, 352);
            this.panel_people.TabIndex = 17;
            // 
            // dgv_ListStockePie
            // 
            this.dgv_ListStockePie.AllowUserToAddRows = false;
            this.dgv_ListStockePie.AllowUserToDeleteRows = false;
            this.dgv_ListStockePie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListStockePie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name});
            this.dgv_ListStockePie.Location = new System.Drawing.Point(3, 38);
            this.dgv_ListStockePie.Name = "dgv_ListStockePie";
            this.dgv_ListStockePie.ReadOnly = true;
            this.dgv_ListStockePie.Size = new System.Drawing.Size(793, 311);
            this.dgv_ListStockePie.TabIndex = 8;
            this.dgv_ListStockePie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListStockePie_CellContentClick);
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // lbl_People
            // 
            this.lbl_People.AutoSize = true;
            this.lbl_People.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_People.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_People.Location = new System.Drawing.Point(12, 9);
            this.lbl_People.Name = "lbl_People";
            this.lbl_People.Size = new System.Drawing.Size(150, 29);
            this.lbl_People.TabIndex = 6;
            this.lbl_People.Text = "List Stockpie";
            // 
            // StockPieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_people);
            this.Controls.Add(this.btn_People);
            this.Controls.Add(this.btn_Stockpie);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.btn_load_file);
            this.Controls.Add(this.cbx_ListFilesSave);
            this.Controls.Add(this.lbl_result_process);
            this.Controls.Add(this.label1);
            this.Name = "StockPieForm";
            this.Text = "StockPie";
            this.panel_people.ResumeLayout(false);
            this.panel_people.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListStockePie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_People;
        private System.Windows.Forms.Button btn_Stockpie;
        private System.Windows.Forms.Button reload;
        private System.Windows.Forms.Button btn_load_file;
        private System.Windows.Forms.ComboBox cbx_ListFilesSave;
        private System.Windows.Forms.Label lbl_result_process;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_people;
        private System.Windows.Forms.DataGridView dgv_ListStockePie;
        private System.Windows.Forms.Label lbl_People;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
    }
}