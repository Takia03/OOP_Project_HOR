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
                utility.addkori();
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

            if (File.Exists(directory_varatia))
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
                    //MessageBox.Show(ex.Message + "mc");
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
                        utility.currentuser = u;
                        break;
                    }
                }
                if (flag)
                {
                    string uname = username_login_textBox.Text;
                    utility.currentdir = utility.folderdir + utility.slash + uname + utility.slash;
                    propertyread();
                    allpropertyread();
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
                        utility.currentuser = u;
                        break;
                    }
                    
                }
                if (flag)
                {
                    
                    //propertyread();
                    allpropertyread();

                    HomePage l2h = new HomePage();
                    l2h.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login error! Enter correct credentials. " +
                        "If you don't have an account, create one.");
                } 
            }

        }

        private void propertyread()
        {
            StreamReader sw = new StreamReader(utility.currentdir + "properties.txt");
            string s = sw.ReadLine();
            while(s != null)
            {
                string[] p = s.Split(',');
                string name = p[0];
                string city = p[1];
                string location = p[2];
                string room = p[3];
                string mas_bed = p[4];
                string bath = p[5];
                string balcony = p[6];
                string size = p[7];
                string rent = p[8];

                
                    bool gasline = Convert.ToBoolean(p[9]);
                    bool water = Convert.ToBoolean(p[10]);
                    bool park = Convert.ToBoolean(p[11]);
                    bool lake = Convert.ToBoolean(p[12]);
                    bool electricity = Convert.ToBoolean(p[13]);
                    bool security = Convert.ToBoolean(p[14]);
                    bool elevator = Convert.ToBoolean(p[15]);
                    bool market = Convert.ToBoolean(p[16]);
                    bool religious = Convert.ToBoolean(p[17]);
                    bool education = Convert.ToBoolean(p[18]);
                    bool parking = Convert.ToBoolean(p[19]);
                    bool intercom = Convert.ToBoolean(p[20]);
                    bool cleaning = Convert.ToBoolean(p[21]);
                    bool maintenance = Convert.ToBoolean(p[22]);

                    string uname = p[23];

                    
                    property ppp = new property(location, name, city, room, mas_bed, bath, balcony, size, rent, gasline, water, park, lake, electricity, security, elevator, market, religious, education, parking, intercom, cleaning, maintenance);


                    foreach (user u in utility.users)
                    {
                        if (u.uname == uname)
                        {
                            ppp.users = u;
                            break;
                        }
                    }
                    utility.properties.Add(ppp);
                    s = sw.ReadLine();
                
                
            }
            sw.Close();
        }

        private void allpropertyread()
        {
            StreamReader sw = new StreamReader(@"C:\HoR\All Properties.txt");
            string s = sw.ReadLine();
            while (s != null)
            {
                string[] p = s.Split(',');
                string name = p[0];
                string city = p[1];
                string location = p[2];
                string room = p[3];
                string mas_bed = p[4];
                string bath = p[5];
                string balcony = p[6];
                string size = p[7];
                string rent = p[8];

                bool gasline = Convert.ToBoolean(p[9]);
                bool water = Convert.ToBoolean(p[10]);
                bool park = Convert.ToBoolean(p[11]);
                bool lake = Convert.ToBoolean(p[12]);
                bool electricity = Convert.ToBoolean(p[13]);
                bool security = Convert.ToBoolean(p[14]);
                bool elevator = Convert.ToBoolean(p[15]);
                bool market = Convert.ToBoolean(p[16]);
                bool religious = Convert.ToBoolean(p[17]);
                bool education = Convert.ToBoolean(p[18]);
                bool parking = Convert.ToBoolean(p[19]);
                bool intercom = Convert.ToBoolean(p[20]);
                bool cleaning = Convert.ToBoolean(p[21]);
                bool maintenance = Convert.ToBoolean(p[22]);

                string uname = p[23];



                property ppp = new property(location, name, city, room, mas_bed, bath, balcony, size, rent, gasline, water, park, lake, electricity, security, elevator, market, religious, education, parking, intercom, cleaning, maintenance);


                foreach (user u in utility.users)
                {
                    if (u.uname == uname)
                    {
                        ppp.users = u;
                        break;
                    }
                }
                utility.allproperties.Add(ppp);

                s = sw.ReadLine();
            }
            sw.Close();
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
