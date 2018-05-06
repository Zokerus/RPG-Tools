namespace RPG_Editor
{
    partial class Stats
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_Stat = new System.Windows.Forms.Label();
            this.cbx_Stats = new System.Windows.Forms.ComboBox();
            this.lbl_StatName = new System.Windows.Forms.Label();
            this.lbl_Abbreviation = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.txb_Abbreviation = new System.Windows.Forms.TextBox();
            this.txb_Description = new System.Windows.Forms.TextBox();
            this.rdb_Regular = new System.Windows.Forms.RadioButton();
            this.rdb_Calculated = new System.Windows.Forms.RadioButton();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.AllowMerge = false;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(423, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.loadToolStripMenuItem.Text = "&Load";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(12, 245);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(93, 245);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(75, 23);
            this.btn_New.TabIndex = 2;
            this.btn_New.Text = "New";
            this.btn_New.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(174, 245);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(255, 245);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(336, 245);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // lbl_Stat
            // 
            this.lbl_Stat.AutoSize = true;
            this.lbl_Stat.Location = new System.Drawing.Point(12, 39);
            this.lbl_Stat.Name = "lbl_Stat";
            this.lbl_Stat.Size = new System.Drawing.Size(29, 13);
            this.lbl_Stat.TabIndex = 6;
            this.lbl_Stat.Text = "Stat:";
            // 
            // cbx_Stats
            // 
            this.cbx_Stats.FormattingEnabled = true;
            this.cbx_Stats.Location = new System.Drawing.Point(83, 36);
            this.cbx_Stats.Name = "cbx_Stats";
            this.cbx_Stats.Size = new System.Drawing.Size(233, 21);
            this.cbx_Stats.TabIndex = 7;
            // 
            // lbl_StatName
            // 
            this.lbl_StatName.AutoSize = true;
            this.lbl_StatName.Location = new System.Drawing.Point(12, 66);
            this.lbl_StatName.Name = "lbl_StatName";
            this.lbl_StatName.Size = new System.Drawing.Size(60, 13);
            this.lbl_StatName.TabIndex = 8;
            this.lbl_StatName.Text = "Stat Name:";
            // 
            // lbl_Abbreviation
            // 
            this.lbl_Abbreviation.AutoSize = true;
            this.lbl_Abbreviation.Location = new System.Drawing.Point(12, 92);
            this.lbl_Abbreviation.Name = "lbl_Abbreviation";
            this.lbl_Abbreviation.Size = new System.Drawing.Size(65, 13);
            this.lbl_Abbreviation.TabIndex = 9;
            this.lbl_Abbreviation.Text = "Abbriviation:";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Location = new System.Drawing.Point(12, 118);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(63, 13);
            this.lbl_Description.TabIndex = 10;
            this.lbl_Description.Text = "Description:";
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Location = new System.Drawing.Point(12, 224);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(56, 13);
            this.lbl_Type.TabIndex = 11;
            this.lbl_Type.Text = "Stat Type:";
            // 
            // txb_Name
            // 
            this.txb_Name.Location = new System.Drawing.Point(83, 63);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(189, 20);
            this.txb_Name.TabIndex = 12;
            // 
            // txb_Abbreviation
            // 
            this.txb_Abbreviation.Location = new System.Drawing.Point(83, 89);
            this.txb_Abbreviation.Name = "txb_Abbreviation";
            this.txb_Abbreviation.Size = new System.Drawing.Size(100, 20);
            this.txb_Abbreviation.TabIndex = 13;
            // 
            // txb_Description
            // 
            this.txb_Description.Location = new System.Drawing.Point(83, 115);
            this.txb_Description.Multiline = true;
            this.txb_Description.Name = "txb_Description";
            this.txb_Description.Size = new System.Drawing.Size(189, 100);
            this.txb_Description.TabIndex = 14;
            // 
            // rdb_Regular
            // 
            this.rdb_Regular.AutoSize = true;
            this.rdb_Regular.Checked = true;
            this.rdb_Regular.Enabled = false;
            this.rdb_Regular.Location = new System.Drawing.Point(83, 222);
            this.rdb_Regular.Name = "rdb_Regular";
            this.rdb_Regular.Size = new System.Drawing.Size(62, 17);
            this.rdb_Regular.TabIndex = 15;
            this.rdb_Regular.TabStop = true;
            this.rdb_Regular.Text = "Regular";
            this.rdb_Regular.UseVisualStyleBackColor = true;
            // 
            // rdb_Calculated
            // 
            this.rdb_Calculated.AutoSize = true;
            this.rdb_Calculated.Enabled = false;
            this.rdb_Calculated.Location = new System.Drawing.Point(151, 222);
            this.rdb_Calculated.Name = "rdb_Calculated";
            this.rdb_Calculated.Size = new System.Drawing.Size(75, 17);
            this.rdb_Calculated.TabIndex = 16;
            this.rdb_Calculated.TabStop = true;
            this.rdb_Calculated.Text = "Calculated";
            this.rdb_Calculated.UseVisualStyleBackColor = true;
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 274);
            this.Controls.Add(this.rdb_Calculated);
            this.Controls.Add(this.rdb_Regular);
            this.Controls.Add(this.txb_Description);
            this.Controls.Add(this.txb_Abbreviation);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.lbl_Type);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.lbl_Abbreviation);
            this.Controls.Add(this.lbl_StatName);
            this.Controls.Add(this.cbx_Stats);
            this.Controls.Add(this.lbl_Stat);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip2;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Stats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Stats";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_Stat;
        private System.Windows.Forms.ComboBox cbx_Stats;
        private System.Windows.Forms.Label lbl_StatName;
        private System.Windows.Forms.Label lbl_Abbreviation;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.TextBox txb_Abbreviation;
        private System.Windows.Forms.TextBox txb_Description;
        private System.Windows.Forms.RadioButton rdb_Regular;
        private System.Windows.Forms.RadioButton rdb_Calculated;
    }
}