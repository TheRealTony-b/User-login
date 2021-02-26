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
            test1.Text = "";
            test2.Text = "";
            string username = Register.finalusername;
            string password = Register.finalpass;
            test1.Text = username;
            test2.Text = password;
        }

        private void test1_Click(object sender, EventArgs e)
        {

        }
    }
}
