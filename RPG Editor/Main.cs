using System;
using System.IO;
using System.Windows.Forms;

namespace RPG_Editor
{
    public partial class Main : Form
    {
        private Game game;

        static string gamePath;
        static string statPath;
        static string npcPath;
        static string itemPath;
        static string skillPath;
        static string jobPath;
        static string questPath;


        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
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
                    DialogResult dialog = MessageBox.Show("The game folder already exists.\nDo you still want to create the directory structure?", "Existing Directory", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                Directory.CreateDirectory(npcPath);
                Directory.CreateDirectory(statPath);
                Directory.CreateDirectory(itemPath);
                Directory.CreateDirectory(skillPath);
                Directory.CreateDirectory(jobPath);
                Directory.CreateDirectory(questPath);

                statsToolStripMenuItem.Enabled = true;
                nPCsToolStripMenuItem.Enabled = true;
                itemsToolStripMenuItem.Enabled = true;
                skillsToolStripMenuItem.Enabled = true;
                jobsToolStripMenuItem.Enabled = true;
                questsToolStripMenuItem.Enabled = true;
            }
        }
    }
}
