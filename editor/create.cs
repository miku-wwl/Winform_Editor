using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace editor
{
    public partial class create : Form
    {
        Account account = new Account();
        public create()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void create_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            account.Read();
            account.Print();
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" ||
                textBox4.Text == "" || textBox5.Text == "" ||
                comboBox1.Text == "")
            {
                MessageBox.Show("User information cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = 0; i <= account.count; i++)
            {
                if (account.userName[i] == textBox1.Text.ToString())
                {
                    MessageBox.Show("Username has been used!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (textBox2.ToString() != textBox3.ToString())
            {
                MessageBox.Show("The two passwords entered are inconsistent!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (StreamWriter sw = new StreamWriter("login.txt", true))
            {
                sw.WriteLine("");
                sw.Write("{0},{1},{2},{3},{4},{5}", textBox1.Text.ToString(), textBox2.Text.ToString(),comboBox1.Text.ToString()
                                                  , textBox4.Text.ToString(), textBox5.Text.ToString(),  dateTimePicker1.Value.ToString("dd-MM-yyyy") );
                sw.Close();

     
                MessageBox.Show("Create Successfully!", "Create");
                return;
            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void create_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
