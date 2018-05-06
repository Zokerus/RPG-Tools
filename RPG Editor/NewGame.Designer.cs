namespace RPG_Editor
{
    partial class NewGame
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.txb_Description = new System.Windows.Forms.TextBox();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Desc = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(162, 190);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(81, 190);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 10;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // txb_Description
            // 
            this.txb_Description.Location = new System.Drawing.Point(81, 50);
            this.txb_Description.Multiline = true;
            this.txb_Description.Name = "txb_Description";
            this.txb_Description.Size = new System.Drawing.Size(211, 134);
            this.txb_Description.TabIndex = 9;
            // 
            // txb_Name
            // 
            this.txb_Name.Location = new System.Drawing.Point(81, 15);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(211, 20);
            this.txb_Name.TabIndex = 8;
            // 
            // lbl_Desc
            // 
            this.lbl_Desc.AutoSize = true;
            this.lbl_Desc.Location = new System.Drawing.Point(12, 53);
            this.lbl_Desc.Name = "lbl_Desc";
            this.lbl_Desc.Size = new System.Drawing.Size(63, 13);
            this.lbl_Desc.TabIndex = 7;
            this.lbl_Desc.Text = "Description:";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(37, 18);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(38, 13);
            this.lbl_Name.TabIndex = 6;
            this.lbl_Name.Text = "Name:";
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 227);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txb_Description);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.lbl_Desc);
            this.Controls.Add(this.lbl_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.TextBox txb_Description;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.Label lbl_Desc;
        private System.Windows.Forms.Label lbl_Name;
    }
}