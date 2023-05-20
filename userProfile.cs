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
            name_label.Text = utility.currentuser.name;
            uname_label.Text = utility.currentuser.uname;
            email_label.Text = utility.currentuser.email;
            mobile_label.Text = utility.currentuser.mobile;

            listmaker();

        }

        private void listmaker()
        {
            listBox_bariwala.Items.Clear();
            string s = $"Name\tRooms\tBathrooms\tSize (sft)\tRent (taka)";
            listBox_bariwala.Items.Add(s);
            foreach (property p in utility.properties)
            {
                string ss = $"{p.name}\t{p.room}\t{p.bath}\t{p.size} sft\t{p.rent} taka";
                listBox_bariwala.Items.Add(ss);
            }
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


        }
    }
}
