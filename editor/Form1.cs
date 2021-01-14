using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;




namespace editor
{
    public partial class Form1 : Form
    {
        public Form1(string userType,string name)
        {
            InitializeComponent();
            //toolStripLabel1.Text = userType;
            toolStripStatusLabel3.Text = DateTime.Now.ToString();
            timer1.Start();
            if (userType=="View") this.richTextBox1.ReadOnly = true;
           // toolStripMenuLabel3.Text = DateTime.Now.ToString();

            
          }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            SetFilePath("");
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Hide();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SetFilePath(openFileDialog.FileName);
                    string[] lines = System.IO.File.ReadAllLines(openFileDialog.FileName);
                    int count = -1;
                    foreach (string set in lines)
                    {
                        // Split each line
                        count++;
                        richTextBox1.Text += set;
                        richTextBox1.Text += "\n";
                    }
                }
            }
            catch (Exception ex)
            {
                return;
            }

            string str = openFileDialog.FileName;
            string[] sArray = str.Split('\\');
            //file.Text = sArray[sArray.Length - 1];


            /*
            public FormChild(RichTextBoxStreamType fileType, string filePath,int i)
        {
            InitializeComponent();

        
            this.richTextBox.LoadFile(filePath, fileType);
            this.SetFileTypeIndex(i);
        }
             */

            //file.WindowState = FormWindowState.Maximized;
        }
        private string _filePath = string.Empty;

        public void SetFilePath(string value)
        {
            _filePath = value;
        }



        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
          
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter myStream;

            saveFileDialog1.Filter = "rtf files (*.rtf)|*.txt|txt files (*.txt)|*.txt|All files (*.*)|*.*";

            saveFileDialog1.FilterIndex = 2;

            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)

            {

                myStream = new StreamWriter(saveFileDialog1.FileName);

                myStream.Write(richTextBox1.Text); //写入

                myStream.Close();//关闭流

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_filePath == "") this.saveAsToolStripMenuItem_Click(sender, e);
            else {
                StreamWriter myStream;
                myStream = new StreamWriter(_filePath);

                myStream.Write(richTextBox1.Text); //写入

                myStream.Close();//关闭流
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(this.Font, FontStyle.Bold);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(this.Font, FontStyle.Italic);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(this.Font, FontStyle.Underline);

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

    

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
             
        }
        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }
        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            this.pasteToolStripMenuItem_Click(sender, e);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright © 2020 Weilai Wang. All Rights Reserved.");
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)

        {
            System.Environment.Exit(0);
            // Application.Exit();
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString();
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.newToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.openToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            saveAsToolStripMenuItem_Click(sender, e);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright © 2020 Weilai Wang. All Rights Reserved.");
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
        
        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {
            //string fontName = richTextBox1.SelectionFont.Name;
            //richTextBox1.SelectionFont = new Font(fontName, richTextBox1.SelectionFont.Size +10);

        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            aboutToolStripMenuItem_Click(sender, e);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
           

        }
    }
}
