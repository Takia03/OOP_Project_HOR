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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            if(utility.currentuser.type == "Tenent")
            {
                addpro_LL.Hide();
                profile_LL.Hide();
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            userProfile upf1 = new userProfile();
            upf1.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            add_property a1 = new add_property();
            a1.Show();
            this.Hide();

        }

        private void search_button_Click(object sender, EventArgs e)
        {
            //label2.Text = Convert.ToString(utility.allproperties.Count);
            
            Search_UI home_to_search1= new Search_UI();
            home_to_search1.Show();
            this.Hide();
        }

        private void logout_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_Form home_to_login1= new Login_Form();
            home_to_login1.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
