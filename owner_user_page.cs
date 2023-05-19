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
    public partial class owner_user_page : Form
    {
        public owner_user_page()
        {
            InitializeComponent();
        }

        private void owner_user_page_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            Application.Exit();

        }

        private void button_home_Click(object sender, EventArgs e)
        {
           
            

        }

        private void home_button_Click(object sender, EventArgs e)
        {
            HomePage h4 = new HomePage();
            h4.Show();
            this.Hide();
        }
    }
}
