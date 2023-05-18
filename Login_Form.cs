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
                user_read();

            }
            else
            {
                DirectoryInfo dir = new DirectoryInfo(@"C:\HoR");
                dir.Create();
            }
        }
        static string directory_varatia = utility.folderdir + utility.slash + "varatia.txt";
        static string directory_bariwala = utility.folderdir + utility.slash + "bariwala.txt";

        //reading user
        public void user_read()
        {
            // $"{name},{uname},{email},{mobile},{pass}"


            if (File.Exists(directory_bariwala))
            {
                try
                {
                    StreamReader stringread = new StreamReader(directory_bariwala);
                    string User = stringread.ReadLine();
                    while (User != null)
                    {
                        string[] userfrags = User.Split(',');
                        string name = userfrags[0];
                        string username = userfrags[1];
                        string email = userfrags[2];
                        string mobile = userfrags[3];
                        string password = userfrags[4];
                        string type = userfrags[5];

                        user u = new user(name, username, email, mobile, password, type);
                        utility.Bariwala.Add(u);

                        User = stringread.ReadLine();
                    }
                    stringread.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please signup First");
            }

            if (File.Exists(directory_bariwala))
            {
                try
                {
                    StreamReader stringread = new StreamReader(directory_varatia);
                    string User = stringread.ReadLine();
                    while (User != null)
                    {
                        string[] userfrags = User.Split(',');
                        string name = userfrags[0];
                        string username = userfrags[1];
                        string email = userfrags[2];
                        string mobile = userfrags[3];
                        string password = userfrags[4];
                        string type = userfrags[5];

                        user u = new user(name, username, email, mobile, password, type);
                        utility.Varatia.Add(u);

                        User = stringread.ReadLine();
                    }
                    stringread.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please signup First");
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
            string user = username_login_textBox.Text;
            string password = password_login_textBox.Text;
            bool flag = false;

            if (user_type_cb.Text == "Landlord")
            {
                foreach (user u in utility.Bariwala)
                {
                    if (u.uname == user && u.password == password)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    HomePage h2 = new HomePage();
                    h2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login error! Enter correct credentials. " +
                        "If you don't have an account, create one.");
                }
            }
            else
            {
                foreach (user u in utility.Varatia)
                {
                    if (u.uname == user && u.password == password)
                    {
                        flag = true;
                        break;
                    }
                    
                }
                if (flag)
                {
                    HomePage_Bharatia l2hv = new HomePage_Bharatia();
                    l2hv.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login error! Enter correct credentials. " +
                        "If you don't hal,;<ve an account, create one.");
                } 
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if(password_login_textBox.UseSystemPasswordChar) 
            {
                password_login_textBox.UseSystemPasswordChar = false;
                
            }
            else
            {
                password_login_textBox.UseSystemPasswordChar = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void username_login_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
