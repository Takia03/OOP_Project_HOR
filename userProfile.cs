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
    public partial class userProfile : Form
    {
        public userProfile()
        {
            InitializeComponent();
        }

        private void h_button_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            HomePage h1 = new HomePage();
            h1.Show();
            this.Hide();
        }

        private void name_label_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
           
=======


            //name_label.Text = utility.currentuser.name;
            //uname_label.Text = utility.currentuser.uname;
            // email_label.Text = utility.currentuser.email;
            //mobile_label.Text = utility.currentuser.mobile;


>>>>>>> 2890c81665890a255e3b4bc46fcd9447d02f2697

        }
    }
}
