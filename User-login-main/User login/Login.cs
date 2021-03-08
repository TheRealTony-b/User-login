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
            string returnValue = "";
            GenerateXML genXML = new GenerateXML();
            User.finalusername = Username.Text;
            User.finalpass = Password.Text;
            returnValue = genXML.readxmL();
            if (returnValue == "good")
            {
                pictureBox1.Visible = true;

            }
            else if (returnValue != "")
            {// Le fichier xml n'existe pas... message d'erreur retourné
                MessageBox.Show(returnValue);
            }
            else
            {
                    // aucun user et password trouvé
                MessageBox.Show("access denied");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
