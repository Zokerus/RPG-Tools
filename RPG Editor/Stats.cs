using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RPG_Editor
{
    public partial class Stats : Form
    {
        SortedDictionary<string, Character.Stat> stats;
        string path;

        public Stats(ref SortedDictionary<string, Character.Stat> _stats, string _path)
        {
            InitializeComponent();
            ResetButtons(false);
            stats = _stats;
            path = _path;
            UpdateComboBox();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            ClearTextboxes();
        }

        private void ResetButtons(bool state)
        {
            btn_New.Enabled = state;
            btn_Update.Enabled = state;
            btn_Delete.Enabled = state;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txb_Name.Text) || string.IsNullOrWhiteSpace(txb_Abbreviation.Text) || string.IsNullOrWhiteSpace(txb_Description.Text))
            {
                return;
            }

            if(stats.ContainsKey(txb_Name.Text))
            {
                MessageBox.Show("This Stat already exists.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Character.Stat.StatType temp = Character.Stat.StatType.Regular;
            if(rdb_Calculated.Checked)
            {
                temp = Character.Stat.StatType.Calculated;
            }

            stats.Add(txb_Name.Text, new Character.Stat(txb_Name.Text, temp, txb_Abbreviation.Text, txb_Description.Text));
            UpdateComboBox();
        }

        private void rdb_Regular_CheckedChanged(object sender, EventArgs e)
        {
            rdb_Calculated.Checked = !rdb_Regular.Checked;
        }

        private void rdb_Calculated_CheckedChanged(object sender, EventArgs e)
        {
            rdb_Regular.Checked = !rdb_Calculated.Checked;
        }

        private void UpdateComboBox()
        {
            cbx_Stats.Items.Clear();
            cbx_Stats.Items.AddRange(stats.Keys.ToArray<string>());
            if (cbx_Stats.Items.Count > 0)
            {
                cbx_Stats.SelectedIndex = 0;
            }
        }

        private void ClearTextboxes()
        {
            txb_Name.Text = "";
            txb_Abbreviation.Text = "";
            txb_Description.Text = "";
        }

        private void txb_Name_TextChanged(object sender, EventArgs e)
        {
            if(txb_Name.Text != "" || txb_Abbreviation.Text != "" || txb_Description.Text != "")
            {
                btn_New.Enabled = true;
            }
            else
            {
                btn_New.Enabled = false;
            }

            if (cbx_Stats.SelectedItem != null)
            {
                if (cbx_Stats.SelectedItem.ToString() == txb_Name.Text && txb_Name.Text != "")
                {
                    ResetButtons(true);
                }
                else
                {
                    btn_Update.Enabled = false;
                    btn_Delete.Enabled = false;
                }
            }
        }

        private void txb_Abbreviation_TextChanged(object sender, EventArgs e)
        {
            if (txb_Name.Text != "" || txb_Abbreviation.Text != "" || txb_Description.Text != "")
            {
                btn_New.Enabled = true;
            }
            else
            {
                btn_New.Enabled = false;
            }
        }

        private void txb_Description_TextChanged(object sender, EventArgs e)
        {
            if (txb_Name.Text != "" || txb_Abbreviation.Text != "" || txb_Description.Text != "")
            {
                btn_New.Enabled = true;
            }
            else
            {
                btn_New.Enabled = false;
            }
        }

        private void cbx_Stats_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbx_Stats.SelectedText == txb_Name.Text && txb_Name.Text != "")
            {
                ResetButtons(true);
            }
            else
            {
                btn_Update.Enabled = false;
                btn_Delete.Enabled = false;
            }

            if(stats.ContainsKey(cbx_Stats.SelectedItem.ToString()))
            {
                txb_Name.Text = stats[cbx_Stats.SelectedItem.ToString()].Name;
                txb_Abbreviation.Text = stats[cbx_Stats.SelectedItem.ToString()].Abbreviation;
                txb_Description.Text = stats[cbx_Stats.SelectedItem.ToString()].Description;
                if(stats[cbx_Stats.SelectedItem.ToString()].Type == Character.Stat.StatType.Regular)
                {
                    rdb_Regular.Checked = true;
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (cbx_Stats.SelectedItem != null)
            {
                if (cbx_Stats.SelectedItem.ToString() == txb_Name.Text && txb_Name.Text != "")
                {
                    Character.Stat.StatType temp = Character.Stat.StatType.Regular;
                    if (rdb_Calculated.Checked)
                    {
                        temp = Character.Stat.StatType.Calculated;
                    }
                    stats[cbx_Stats.SelectedItem.ToString()].Update(temp, txb_Abbreviation.Text, txb_Description.Text);
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (cbx_Stats.SelectedItem != null)
            {
                if (cbx_Stats.SelectedItem.ToString() == txb_Name.Text && txb_Name.Text != "")
                {
                    stats.Remove(cbx_Stats.SelectedItem.ToString());
                    UpdateComboBox();
                }
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(path + @"\Stats.xml"))
            {
                File.Delete(path + @"\Stats.xml");
            }
            XmlWriter writer = XmlWriter.Create(path + @"\Stats.xml");
            writer.WriteStartDocument();
            writer.WriteStartElement("Stats");

            foreach (KeyValuePair<string, Character.Stat> item in stats)
            {
                writer.WriteStartElement("Stat");
                writer.WriteElementString("Name", item.Value.Name);
                writer.WriteElementString("Abbreviation", item.Value.Abbreviation);
                writer.WriteElementString("Description", item.Value.Description);
                writer.WriteElementString("Type", item.Value.Type.ToString());
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Your current stats will be replace from the saved file.\nDo you want to continue?", "Loading", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                LoadStats();
                UpdateComboBox();
            }
            
        }

        public void LoadStats()
        {
            stats.Clear();
            if (!File.Exists(path + @"\Stats.xml"))
            {
                return;
            }

            XmlDocument xml = new XmlDocument();
            xml.Load(path + @"\Stats.xml");

            XmlElement root = xml.DocumentElement;

            XmlNodeList xn = root.SelectNodes("/Stats/Stat");
            foreach (XmlNode node in xn)
            {
                string name = "", abb = "", desc = "";
                Character.Stat.StatType type = Character.Stat.StatType.Calculated;
                for(int i = 0; i < node.ChildNodes.Count; i++ )
                {
                    switch (node.ChildNodes[i].Name)
                    {
                        case "Name":
                            name = node.ChildNodes[i].InnerText;
                            break;

                        case "Abbreviation":
                            abb = node.ChildNodes[i].InnerText;
                            break;

                        case "Description":
                            desc = node.ChildNodes[i].InnerText;
                            break;

                        case "Type":
                            if(node.ChildNodes[i].InnerText == Character.Stat.StatType.Regular.ToString())
                            {
                                type = Character.Stat.StatType.Regular;
                            }
                            break;
                    }
                }
                stats.Add(name, new Character.Stat(name, type, abb, desc));
            }
        }

        private void Stats_Load(object sender, EventArgs e)
        {
            UpdateComboBox();
        }
    }
}
