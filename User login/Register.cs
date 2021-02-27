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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Create_Click(object sender, EventArgs e)
        {

            if (Password1.Text != Password2.Text)
            {
                MessageBox.Show("The passwords don't match");
                Password2.Text = "";
            }
            if (Username.Text == "")
            {
                MessageBox.Show("Please type in a Username!");
            }
            if (Password1.Text == Password2.Text && Username.Text != "" && Password1.Text != "")
            {
                MessageBox.Show("Account created with sucess!");
                User.finalusername = Username.Text;
                    User.finalpass = Password1.Text;
            }
            if (Password1.Text == "")
            {
                MessageBox.Show("Please type in a password!");
            
            }
            if (Password2.Text == "")
            {
                MessageBox.Show("Please confirm your password!");
            }

        }

    }
}
