using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CapstoneProject
{
    public partial class Form1 : Form
    {
        PictureBox[,] pb;
        int xOffset = 0;
        int yOffset = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pb = new PictureBox[5, 5];

            for (int i = 0; i < 5; i++)
            {
                xOffset = 0;
                for (int j = 0; j < 5; j++)
                {
                    pb[i, j] = new PictureBox();
                    pb[i, j].Size = new Size(72, 72);
                    pb[i, j].Location = new Point(xOffset, yOffset);
                    pb[i, j].BorderStyle = BorderStyle.Fixed3D;
                    pb[i, j].Visible = true;
                    pb[i, j].SizeMode = PictureBoxSizeMode.Zoom;
                    pb[i, j].MouseClick += new MouseEventHandler(PB_Click);
                    panelMain.Controls.Add(pb[i, j]);
                    xOffset += 72;
                }
                yOffset += 72;
            }
        }

        private void PB_Click(object sender, EventArgs e)
        {
            ((PictureBox)sender).Image = currentPB.Image;
            ((PictureBox)sender).Tag = currentPB.Tag;

        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofp = new OpenFileDialog();
            ofp.Filter = "Game Map File|*.gamemap|All Files|*.*";
            StreamReader sr;

            string fullLine;
            string[] tiles;
            int row = 0;

            if (ofp.ShowDialog() == DialogResult.OK)
            {
                sr = File.OpenText(ofp.FileName);

                while (!sr.EndOfStream)
                {
                    fullLine = sr.ReadLine();

                    tiles = fullLine.Split();

                    for (int col = 0; col < tiles.Length; col++)
                    {
                        if (tiles[col].ToString() == "0")
                        {
                            pb[row, col].Image = Properties.Resources.Rage_Face;
                            pb[row, col].Tag = "rage";
                        }
                        else if (tiles[col].ToString() == "1")
                        {
                            pb[row, col].Image = Properties.Resources.tard_the_cat;
                            pb[row, col].Tag = "cat";
                        }
                        else if (tiles[col].ToString() == "2")
                        {
                            pb[row, col].Image = Properties.Resources.troll_face;
                            pb[row, col].Tag = "troll";
                        }
                        else if (tiles[col].ToString() == "3")
                        {
                            pb[row, col].Image = Properties.Resources.genius;
                            pb[row, col].Tag = "genius";
                        }
                        else if (tiles[col].ToString() == "4")
                        {
                            pb[row, col].Image = Properties.Resources.me_gusta;
                            pb[row, col].Tag = "me_gusta";
                        }
                    }//end for


                    row++;

                }//end while

                sr.Close();
            }


        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Game Map File|*.gamemap|All Files|*.*";
            StreamWriter sw;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                sw = File.CreateText(sfd.FileName);
                //write data from file

                for (int row = 0; row < 5; row++)
                {
                    for (int col = 0; col < 5; col++)
                    {
                        PictureBox thisPB = pb[row, col];

                        if (thisPB.Tag == "rage")
                        {
                            sw.Write("0");
                        }
                        else if (thisPB.Tag == "cat")
                        {
                            sw.Write("1");
                        }
                        else if (thisPB.Tag == "troll")
                        {
                            sw.Write("2");
                        }
                        else if (thisPB.Tag == "genius")
                        {
                            sw.Write("3");
                        }
                        else if (thisPB.Tag == "me_gusta")
                        {
                            sw.Write("4");
                        }

                        if (col != 4)
                        {
                            sw.Write(" ");
                        }
                    }//end for col

                    if (row != 4)
                    {
                        sw.WriteLine();
                    }

                }//end for row


                sw.Close();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            currentPB.Image = Properties.Resources.Rage_Face;
            currentPB.Tag = "rage";

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            currentPB.Image = Properties.Resources.tard_the_cat;
            currentPB.Tag = "cat";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            currentPB.Image = Properties.Resources.genius;
            currentPB.Tag = "genius";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            currentPB.Image = Properties.Resources.troll_face;
            currentPB.Tag = "troll";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            currentPB.Image = Properties.Resources.me_gusta;
            currentPB.Tag = "me_gusta";
        }

    }
}
