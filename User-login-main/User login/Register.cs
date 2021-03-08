using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace User_login
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            FilePathLabel.Text = "";
            pnlSignUp.Visible = false;



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
            String nomFichier2 = GenerateXML.nomFichier;
            GenerateXML genXML = new GenerateXML();
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
                genXML.editxmL();
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

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK)
                            {
                    //Get the path of specified file
                  User.filePath = fbd.SelectedPath;
                    if (User.filePath != "")
                    { pnlSignUp.Visible = true; }
                }
    }
}

        private void button3_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
              
                openFileDialog.Filter = "xml files (*.xml)|*.xml";

                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    User.filePath = openFileDialog.FileName;
                }
            }
            if (User.filePath != "")
            { pnlSignUp.Visible = true; }
           
             }
    }
}

