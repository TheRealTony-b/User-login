using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
        }

        private void test1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (User.finalusername == Username.Text && User.finalpass == Password.Text)
            {
                MessageBox.Show("Succesfully logged in!");
                pictureBox1.Visible = true;
            }
            else if (User.finalusername != Username.Text)
            {
                MessageBox.Show("Incorrect username/ Username not found");
            }
            else if (User.finalpass != Password.Text)
            {
                MessageBox.Show("Incorrect password/ Password not found");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }
    }
}
