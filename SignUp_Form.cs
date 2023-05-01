using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace OOP_Project_HOR
{
    public partial class SignUp_Form : Form
    {
        public SignUp_Form()
        {
            InitializeComponent();

            name_signup_textBox.Text = null;
            username_signup_textBox.Text = null; ;
            email_signup_textBox.Text = null;;
            mobile_signup_textBox.Text = null;;
            password_signup_textBox.Text = null;;
            retype_signup_textBox.Text = null;

        }

        private void exit_signup_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_button_Click(object sender, EventArgs e)
        {

            
            userwrite();


            MessageBox.Show("Sign Up Successful");

            name_signup_textBox.Clear();
            username_signup_textBox.Clear();
            email_signup_textBox.Clear();
            mobile_signup_textBox.Clear();
            password_signup_textBox.Clear();
            retype_signup_textBox.Clear();

            Login_Form l1 = new Login_Form();
            l1.Show();
            this.Hide();
            
            
        }
        static string directory = utility.folderdir + utility.slash + "user.txt";
        
        private void userwrite()
        {
            string name = name_signup_textBox.Text;
            string uname = username_signup_textBox.Text;
            string email = email_signup_textBox.Text;
            string mobile = mobile_signup_textBox.Text;
            string pass = password_signup_textBox.Text;
            string retype = retype_signup_textBox.Text;



            if (pass == retype)
            {
                if (pass.Length > 5)
                {
                    user u = new user(name, uname, email, mobile, pass);
                    utility.users.Add(u);

                    if (File.Exists(directory))
                    {
                        habijabi();
                    }
                    else
                    {
                        File.Create(directory);
                        habijabi();
                    }
                }
                else
                {
                    MessageBox.Show("Password must have at least 6 characters");
                }
            }
            else
            {
                MessageBox.Show("Password and Retype Password does not match");
            }
        }
        private void habijabi()
        {
            string name = name_signup_textBox.Text;
            string uname = username_signup_textBox.Text;
            string email = email_signup_textBox.Text;
            string mobile = mobile_signup_textBox.Text;
            string pass = password_signup_textBox.Text;
            string retype = retype_signup_textBox.Text;

            StreamWriter sw = File.AppendText(directory);
            string q = $"{name},{uname},{email},{mobile},{pass}";
            sw.WriteLine(q); ;
            sw.Close();
        }

        private void pass_pictureBox_Click(object sender, EventArgs e)
        {
            if(password_signup_textBox.UseSystemPasswordChar)
            {
                password_signup_textBox.UseSystemPasswordChar = false;
            }
            else
            {
                password_signup_textBox.UseSystemPasswordChar = true;
            }
        }

        private void repass_pictureBox_Click(object sender, EventArgs e)
        {
            if (retype_signup_textBox.UseSystemPasswordChar)
            {
                retype_signup_textBox.UseSystemPasswordChar = false;
            }
            else
            {
                retype_signup_textBox.UseSystemPasswordChar = true;
            }
        }
    }
}
