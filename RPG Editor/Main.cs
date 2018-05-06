using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace RPG_Editor
{
    public partial class Main : Form
    {
        private Game game;
        SortedDictionary<string, Character.Stat> stats;

        static string gamePath;
        static string statPath;
        static string npcPath;
        static string itemPath;
        static string skillPath;
        static string jobPath;
        static string questPath;

        Stats frmStats;


        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stats = new SortedDictionary<string, Character.Stat>();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame newGame = new NewGame();
            DialogResult result = newGame.ShowDialog();

            if(result == DialogResult.OK && newGame.Data != null)
            {
                game = newGame.Data;
                CreateDirectoryStructure();
            }
        }

        private void CreateDirectoryStructure()
        {
            ResetMenuSettings(false);

            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "Select directory of the new game";
            folderBrowser.SelectedPath = Application.StartupPath;

            DialogResult result = folderBrowser.ShowDialog();

            if(result == DialogResult.OK)
            {
                gamePath = Path.Combine(folderBrowser.SelectedPath, game.Name);
                npcPath = Path.Combine(gamePath, "Character");
                statPath = Path.Combine(npcPath, "Stats");
                itemPath = Path.Combine(gamePath, "Items");
                skillPath = Path.Combine(gamePath, "Skills");
                jobPath = Path.Combine(gamePath, "Jobs");
                questPath = Path.Combine(gamePath, "Quests");

                if(Directory.Exists(gamePath))
                {
                    DialogResult dialog = MessageBox.Show("The game folder already exists.\nDo you still want to create the directory structure and overwright existing files?", "Existing Directory", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dialog == DialogResult.No)
                    {
                        //Folder is existing and aborting the creation of the system.
                        //Reset all paths and game class
                        gamePath = "";
                        statPath = "";
                        npcPath = "";
                        itemPath = "";
                        skillPath = "";
                        jobPath = "";
                        questPath = "";
                        game = new Game();
                        return;
                    }
                }
                else
                {
                    Directory.CreateDirectory(gamePath);
                }

                //Existing detection is included
                gamePath = Path.Combine(gamePath, "Game");
                Directory.CreateDirectory(gamePath);
                Directory.CreateDirectory(npcPath);
                Directory.CreateDirectory(statPath);
                Directory.CreateDirectory(itemPath);
                Directory.CreateDirectory(skillPath);
                Directory.CreateDirectory(jobPath);
                Directory.CreateDirectory(questPath);

                statsToolStripMenuItem.Enabled = true;

                if(File.Exists(gamePath + @"\Game.xml"))
                {
                    File.Delete(gamePath + @"\Game.xml");
                }
                XmlWriter writer = XmlWriter.Create(gamePath + @"\Game.xml");
                writer.WriteStartDocument();
                writer.WriteStartElement("Game");

                writer.WriteElementString("Name", game.Name);
                writer.WriteElementString("Description", game.Description);

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();

                LoadData();
            }
        }

        private void statsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(frmStats == null || frmStats.IsDisposed)
            {
                frmStats = new Stats(ref stats, statPath);
                frmStats.MdiParent = this;
            }

            frmStats.Show();
            frmStats.BringToFront();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetMenuSettings(false);

            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "Select your game directory";
            folderBrowser.SelectedPath = Application.StartupPath;

            DialogResult result = folderBrowser.ShowDialog();

            if(result != DialogResult.OK)
            {
                //There was no valid directory path
                return;
            }

            if(!File.Exists(folderBrowser.SelectedPath + @"\Game\Game.xml"))
            {
                MessageBox.Show("There was no Game.xml file.", "File missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            XmlDocument xml = new XmlDocument();
            xml.Load(folderBrowser.SelectedPath + @"\Game\Game.xml");

            XmlElement root = xml.DocumentElement;
            XmlNodeList xn = root.SelectNodes("/Game/Name");
            if(xn.Count != 1)
            {
                MessageBox.Show("There was a failure inside the Game.xml.\nMultiple Node named \"Name\"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            XmlNodeList xn2 = root.SelectNodes("/Game/Description");
            if (xn2.Count != 1)
            {
                MessageBox.Show("There was a failure inside the Game.xml.\nMultiple Node named \"Name\"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            game = new Game(xn[0].InnerText, xn2[0].InnerText);

            gamePath = folderBrowser.SelectedPath;
            npcPath = Path.Combine(gamePath, "Character");
            statPath = Path.Combine(npcPath, "Stats");
            itemPath = Path.Combine(gamePath, "Items");
            skillPath = Path.Combine(gamePath, "Skills");
            jobPath = Path.Combine(gamePath, "Jobs");
            questPath = Path.Combine(gamePath, "Quests");
            gamePath = Path.Combine(gamePath, "Game");

            statsToolStripMenuItem.Enabled = true;
            LoadData();
        }

        private void ResetMenuSettings(bool state)
        {
            statsToolStripMenuItem.Enabled = state;
            nPCsToolStripMenuItem.Enabled = state;
            itemsToolStripMenuItem.Enabled = state;
            skillsToolStripMenuItem.Enabled = state;
            jobsToolStripMenuItem.Enabled = state;
            questsToolStripMenuItem.Enabled = state;
        }

        private void LoadData()
        {
            if (frmStats == null || frmStats.IsDisposed)
            {
                frmStats = new Stats(ref stats, statPath);
                frmStats.MdiParent = this;
            }

            frmStats.LoadStats();

            if(stats.Count > 0)
            {
                ResetMenuSettings(true);
            }
        }
    }
}
