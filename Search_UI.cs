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
    public partial class Search_UI : Form
    {
        public Search_UI()
        {
            InitializeComponent();
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            HomePage h5 = new HomePage();
            h5.Show();
            this.Hide();
        }
    }
}
