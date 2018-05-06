using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_Editor
{
    public partial class NewGame : Form
    {
        private Game data;
        
        public Game Data
        {
            get { return data; }
        }

        public NewGame()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txb_Name.Text) || string.IsNullOrEmpty(txb_Description.Text))
            {
                MessageBox.Show("You must enter a name and a description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            data = new Game(txb_Name.Text, txb_Description.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
