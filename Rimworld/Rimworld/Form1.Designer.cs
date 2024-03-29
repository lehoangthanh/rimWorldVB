﻿namespace Rimworld
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_result_process = new System.Windows.Forms.Label();
            this.cbx_ListFilesSave = new System.Windows.Forms.ComboBox();
            this.btn_load_file = new System.Windows.Forms.Button();
            this.btn_up_skill = new System.Windows.Forms.Button();
            this.dgv_ListPeople = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kindDef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_People = new System.Windows.Forms.Label();
            this.reload = new System.Windows.Forms.Button();
            this.btn_Stockpie = new System.Windows.Forms.Button();
            this.btn_People = new System.Windows.Forms.Button();
            this.kill_the_enemy = new System.Windows.Forms.Button();
            this.btn_reset_heal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Save";
            // 
            // lbl_result_process
            // 
            this.lbl_result_process.AutoSize = true;
            this.lbl_result_process.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result_process.Location = new System.Drawing.Point(485, 11);
            this.lbl_result_process.Name = "lbl_result_process";
            this.lbl_result_process.Size = new System.Drawing.Size(147, 22);
            this.lbl_result_process.TabIndex = 1;
            this.lbl_result_process.Text = "Message Results";
            // 
            // cbx_ListFilesSave
            // 
            this.cbx_ListFilesSave.FormattingEnabled = true;
            this.cbx_ListFilesSave.Location = new System.Drawing.Point(69, 12);
            this.cbx_ListFilesSave.Name = "cbx_ListFilesSave";
            this.cbx_ListFilesSave.Size = new System.Drawing.Size(248, 21);
            this.cbx_ListFilesSave.TabIndex = 2;
            // 
            // btn_load_file
            // 
            this.btn_load_file.Location = new System.Drawing.Point(323, 10);
            this.btn_load_file.Name = "btn_load_file";
            this.btn_load_file.Size = new System.Drawing.Size(75, 23);
            this.btn_load_file.TabIndex = 3;
            this.btn_load_file.Text = "Load";
            this.btn_load_file.UseVisualStyleBackColor = true;
            this.btn_load_file.Click += new System.EventHandler(this.button_load_file);
            // 
            // btn_up_skill
            // 
            this.btn_up_skill.Location = new System.Drawing.Point(150, 107);
            this.btn_up_skill.Name = "btn_up_skill";
            this.btn_up_skill.Size = new System.Drawing.Size(97, 26);
            this.btn_up_skill.TabIndex = 4;
            this.btn_up_skill.Text = "Up Skill";
            this.btn_up_skill.UseVisualStyleBackColor = true;
            this.btn_up_skill.Click += new System.EventHandler(this.button_upSkill);
            // 
            // dgv_ListPeople
            // 
            this.dgv_ListPeople.AllowUserToAddRows = false;
            this.dgv_ListPeople.AllowUserToDeleteRows = false;
            this.dgv_ListPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_ListPeople.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_ListPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListPeople.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fullname,
            this.nick,
            this.kindDef});
            this.dgv_ListPeople.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_ListPeople.Location = new System.Drawing.Point(0, 139);
            this.dgv_ListPeople.Name = "dgv_ListPeople";
            this.dgv_ListPeople.ReadOnly = true;
            this.dgv_ListPeople.Size = new System.Drawing.Size(964, 396);
            this.dgv_ListPeople.TabIndex = 8;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 41;
            // 
            // fullname
            // 
            this.fullname.HeaderText = "Name";
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            this.fullname.Width = 60;
            // 
            // nick
            // 
            this.nick.HeaderText = "Nick";
            this.nick.Name = "nick";
            this.nick.ReadOnly = true;
            this.nick.Width = 54;
            // 
            // kindDef
            // 
            this.kindDef.HeaderText = "KindDef";
            this.kindDef.Name = "kindDef";
            this.kindDef.ReadOnly = true;
            this.kindDef.Width = 70;
            // 
            // lbl_People
            // 
            this.lbl_People.AutoSize = true;
            this.lbl_People.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_People.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_People.Location = new System.Drawing.Point(10, 107);
            this.lbl_People.Name = "lbl_People";
            this.lbl_People.Size = new System.Drawing.Size(134, 29);
            this.lbl_People.TabIndex = 6;
            this.lbl_People.Text = "List People";
            // 
            // reload
            // 
            this.reload.Location = new System.Drawing.Point(404, 10);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(75, 23);
            this.reload.TabIndex = 6;
            this.reload.Text = "ReLoad";
            this.reload.UseVisualStyleBackColor = true;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // btn_Stockpie
            // 
            this.btn_Stockpie.Location = new System.Drawing.Point(133, 63);
            this.btn_Stockpie.Name = "btn_Stockpie";
            this.btn_Stockpie.Size = new System.Drawing.Size(97, 26);
            this.btn_Stockpie.TabIndex = 8;
            this.btn_Stockpie.Text = "Stock Pie";
            this.btn_Stockpie.UseVisualStyleBackColor = true;
            this.btn_Stockpie.Click += new System.EventHandler(this.btn_Stockpie_Click);
            // 
            // btn_People
            // 
            this.btn_People.Location = new System.Drawing.Point(17, 63);
            this.btn_People.Name = "btn_People";
            this.btn_People.Size = new System.Drawing.Size(97, 26);
            this.btn_People.TabIndex = 9;
            this.btn_People.Text = "People";
            this.btn_People.UseVisualStyleBackColor = true;
            this.btn_People.Click += new System.EventHandler(this.btn_People_Click);
            // 
            // kill_the_enemy
            // 
            this.kill_the_enemy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kill_the_enemy.Location = new System.Drawing.Point(342, 109);
            this.kill_the_enemy.Name = "kill_the_enemy";
            this.kill_the_enemy.Size = new System.Drawing.Size(120, 24);
            this.kill_the_enemy.TabIndex = 10;
            this.kill_the_enemy.Text = "Kill The Enemy";
            this.kill_the_enemy.UseVisualStyleBackColor = true;
            this.kill_the_enemy.Click += new System.EventHandler(this.btn_kill_the_enemy);
            // 
            // btn_reset_heal
            // 
            this.btn_reset_heal.Location = new System.Drawing.Point(253, 109);
            this.btn_reset_heal.Name = "btn_reset_heal";
            this.btn_reset_heal.Size = new System.Drawing.Size(74, 24);
            this.btn_reset_heal.TabIndex = 11;
            this.btn_reset_heal.Text = "Reset Heal";
            this.btn_reset_heal.UseVisualStyleBackColor = true;
            this.btn_reset_heal.Click += new System.EventHandler(this.Btn_resetHealthPeoples);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(964, 535);
            this.Controls.Add(this.btn_reset_heal);
            this.Controls.Add(this.kill_the_enemy);
            this.Controls.Add(this.dgv_ListPeople);
            this.Controls.Add(this.btn_People);
            this.Controls.Add(this.lbl_People);
            this.Controls.Add(this.btn_Stockpie);
            this.Controls.Add(this.btn_up_skill);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.btn_load_file);
            this.Controls.Add(this.cbx_ListFilesSave);
            this.Controls.Add(this.lbl_result_process);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_result_process;
        private System.Windows.Forms.ComboBox cbx_ListFilesSave;
        private System.Windows.Forms.Button btn_load_file;
        private System.Windows.Forms.Button btn_up_skill;
        private System.Windows.Forms.Label lbl_People;
        private System.Windows.Forms.DataGridView dgv_ListPeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn nick;
        private System.Windows.Forms.DataGridViewTextBoxColumn kindDef;
        private System.Windows.Forms.Button reload;
        private System.Windows.Forms.Button btn_Stockpie;
        private System.Windows.Forms.Button btn_People;
        private System.Windows.Forms.Button kill_the_enemy;
        private System.Windows.Forms.Button btn_reset_heal;
    }
}

