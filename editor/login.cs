using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace editor
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)  //new user
        {
            Account account = new Account();
            account.Read();
            account.Print();

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("User information cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = null;
                textBox2.Text = null;
                return;
            }
            for (int i = 0; i <= account.count; i++)
            {
                if (account.userName[i] == textBox1.Text.ToString())
                {
                    MessageBox.Show("Welcome, " + account.firstName[i] +" "+account.lastName[i]+"!");
                    Form1 form1 = new Form1(account.userType[i], account.firstName[i] + " " + account.lastName[i] + "!");
                    form1.Show();
                    this.Hide();
                    return;
                }
            }
            MessageBox.Show("User information is inaccurate!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            textBox1.Text = null;
            textBox2.Text = null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            create create = new create();
            create.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
