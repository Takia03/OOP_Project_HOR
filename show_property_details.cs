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
    public partial class show_property_details : Form
    {
        public show_property_details()
        {
            InitializeComponent();
        }

        private void button_back_search_Click(object sender, EventArgs e)
        {
            
            
            Search_UI s1= new Search_UI();
            s1.Show();
            this.Hide();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }
    }
}
