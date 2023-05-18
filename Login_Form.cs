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
        static string directory = utility.folderdir + utility.slash + "user.txt";
        public void user_read()
        {
            // $"{name},{uname},{email},{mobile},{pass}"

            try
            {
                StreamReader stringread = new StreamReader(directory);
                string User = stringread.ReadLine();
                while (User != null)
                {
                    string[] userfrags = User.Split(',');
                    string name = userfrags[0];
                    string username = userfrags[1];
                    string email = userfrags[2];
                    string mobile = userfrags[3];
                    string password = userfrags[4];

                    //user u = new user(name, username, email, mobile, password);
                    //utility.users.Add(u);

                    User = stringread.ReadLine();
                }
                stringread.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            foreach( user u in utility.users )
            {
                if(u.uname == user && u.password == password)
                {
                    flag = true;
                    break;
                }

            }
            if(flag) 
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
    }
}
