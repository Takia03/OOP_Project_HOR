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
        static string directory_varatia = utility.folderdir + utility.slash + "varatia.txt";
        static string directory_bariwala = utility.folderdir + utility.slash + "bariwala.txt";

        private void userwrite()
        {
            string name = name_signup_textBox.Text;
            string uname = username_signup_textBox.Text;
            string email = email_signup_textBox.Text;
            string mobile = mobile_signup_textBox.Text;
            string pass = password_signup_textBox.Text;
            string retype = retype_signup_textBox.Text;
            string type = user_type_comboBox.Text;



            if (pass == retype)
            {
                if (pass.Length > 5)
                {
                    user u = new user(name, uname, email, mobile, pass, type);
                    utility.users.Add(u);

                    if(user_type_comboBox.Text == "Landlord")
                    {
                        if (File.Exists(directory_bariwala))
                        {
                            habijabi_bariwala();
                        }
                        else
                        {
                            File.Create(directory_bariwala);
                            habijabi_bariwala();
                        }
                    }
                    else
                    {
                        if (File.Exists(directory_varatia))
                        {
                            habijabi_varatia();
                        }
                        else
                        {
                            File.Create(directory_varatia);
                            habijabi_varatia();
                        }
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
        private void habijabi_varatia()
        {
            string name = name_signup_textBox.Text;
            string uname = username_signup_textBox.Text;
            string email = email_signup_textBox.Text;
            string mobile = mobile_signup_textBox.Text;
            string pass = password_signup_textBox.Text;
            string retype = retype_signup_textBox.Text;
            string type = user_type_comboBox.Text;
            

            StreamWriter sw = File.AppendText(directory_varatia);
            string q = $"{name},{uname},{email},{mobile},{pass},{type}";
            sw.WriteLine(q); ;
            sw.Close();
        }
        private void habijabi_bariwala()
        {
            string name = name_signup_textBox.Text;
            string uname = username_signup_textBox.Text;
            string email = email_signup_textBox.Text;
            string mobile = mobile_signup_textBox.Text;
            string pass = password_signup_textBox.Text;
            string retype = retype_signup_textBox.Text;
            string type = user_type_comboBox.Text;

            StreamWriter sw = File.AppendText(directory_bariwala);
            string q = $"{name},{uname},{email},{mobile},{pass},{type}";
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
