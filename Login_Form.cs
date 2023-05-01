using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project_HOR
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();

            if (Directory.Exists(@"C:\HoR"))
            {

            }
            else
            {
                DirectoryInfo dir = new DirectoryInfo(@"C:\HoR");
                dir.Create();
            }
        }

      
        private void signup_label_Click(object sender, EventArgs e)
        {
            SignUp_Form s1 = new SignUp_Form();
            s1.Show();
            this.Hide();
        }

        private void exit_login_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            HomePage h2 = new HomePage();
            h2.Show();
            this.Hide();
        }
    }
}
