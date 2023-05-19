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
    public partial class HomePage_Bharatia : Form
    {
        public HomePage_Bharatia()
        {
            InitializeComponent();
        }

        private void logout_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_Form h2l = new Login_Form();
            h2l.Show();
            this.Hide();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            Search_UI h2s = new Search_UI();
            h2s.Show();
            this.Hide();
        }

        private void profile_LL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            userProfile h2u = new userProfile();
            h2u.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
