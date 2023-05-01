using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project_HOR
{
    public partial class SignUp_Form : Form
    {
        public SignUp_Form()
        {
            InitializeComponent();
        }

        private void exit_signup_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            
            
            
            
            MessageBox.Show("Sign Up Successful");

            name_signup_textBox.Clear();
            username_signup_textBox.Clear();
            email_signup_textBox.Clear();
            mobile_signup_textBox.Clear();
            password_signup_textBox.Clear();
            retype_signup_textBox.Clear();

            Login_Form l1= new Login_Form();
            l1.Show();
            this.Hide();
        }

        private void userwrite()
        {

        }
    }
}
