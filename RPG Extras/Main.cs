using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_Extras
{
    public partial class Main : Form
    {
        public struct VertexType
        {
            public float x;
            public float y;
            public float z;

            public VertexType(float x, float y, float z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
        }

        public struct FaceType
        {
            public int Vertex1;
            public int Vertex2;
            public int Vertex3;
            public int Normal;
            public FaceType(int Vertex1, int Vertex2, int Vertex3, int Normal)
            {
                this.Vertex1 = Vertex1;
                this.Vertex2 = Vertex2;
                this.Vertex3 = Vertex3;
                this.Normal = Normal;
            }
        }

        public Main()
        {
            InitializeComponent();
        }

        private void btnMesh_Click(object sender, EventArgs e)
        {
            string line;
            string[] split;
            int[] faceID = new int[3];
            int[] index = new int[3];
            List<VertexType> vertices = new List<VertexType>();
            List<VertexType> normals = new List<VertexType>();
            List<FaceType> faces = new List<FaceType>();

            OpenFileDialog odialog = new OpenFileDialog();
            odialog.Title = "Wähle die Objektdatei aus.";
            odialog.InitialDirectory = Directory.GetCurrentDirectory();
            odialog.Filter = "Object files (*.obj)|*.obj|All files (*.*)|*.*";
            odialog.FilterIndex = 1;

            SaveFileDialog sdialog = new SaveFileDialog();
            sdialog.Title = "Speichern der umgewandelten Objektdatei.";
            sdialog.InitialDirectory = odialog.FileName;
            sdialog.Filter = "Model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            sdialog.FilterIndex = 1;
            sdialog.OverwritePrompt = true;

            if (odialog.ShowDialog() == DialogResult.OK) //Datei wurde ausgewählt und bestätigt
            {
                if(!File.Exists(odialog.FileName)) //Ausgewählte Datei ist nicht vorhanden
                {
                    MessageBox.Show("Die ausgewählte Datei ist nicht vorhanden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                FileStream fs = new FileStream(odialog.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs);

                while(!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    split = line.Split(' ');
                    if(split.Length <= 0)
                    {
                        continue;
                    }

                    if (split[0] == "o")
                    {
                        //neues Objekt
                    }
                    else if (split[0] == "v")
                    {
                        vertices.Add(new VertexType(Convert.ToSingle(split[1]), Convert.ToSingle(split[2]), Convert.ToSingle(split[3])));
                    }
                    else if (split[0] == "vn")
                    {
                        normals.Add(new VertexType(Convert.ToSingle(split[1]), Convert.ToSingle(split[2]), Convert.ToSingle(split[3])));
                    }
                    else if (split[0] == "f")
                    {
                        //hier müsste ein Check auf dsa richtige Format rein
                        for (int i = 0; i < 3; i++)
                        {
                            faceID[i] = Convert.ToInt32(split[i + 1].Replace("//", "/").Split('/')[1]);
                            index[i] = Convert.ToInt32(split[i + 1].Replace("//", "/").Split('/')[0]);
                        }

                        if (faceID[0] != faceID[1] || faceID[0] != faceID[2])
                        {
                            MessageBox.Show("Die Normalen passen nicht zusaamen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        faces.Add(new FaceType(index[0], index[1], index[2], faceID[0]));
                    }
                }

                sr.Close();
                fs.Close();
                   
                if(sdialog.ShowDialog() == DialogResult.OK)
                {
                    fs = new FileStream(sdialog.FileName, FileMode.Create);
                    BinaryWriter br = new BinaryWriter(fs);

                    br.Write("Vertex Count:");
                    br.Write(vertices.Count());
                    br.Write("Face Count:");
                    br.Write(faces.Count());
                    br.Write("Vertices:");

                    for(int i = 0; i < vertices.Count;i++)
                    {
                        br.Write(vertices[i].x);
                        br.Write(vertices[i].y);
                        br.Write(vertices[i].z);
                    }
                    br.Write("Faces:");
                    for (int i = 0; i < faces.Count; i++)
                    {
                        br.Write(faces[i].Vertex1);
                        br.Write(faces[i].Vertex2);
                        br.Write(faces[i].Vertex3);
                    }

                    br.Close();
                    fs.Close();
                }
            }

        }
    }
}
