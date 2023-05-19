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
        List<property> propertyList = new List<property>();
        public Search_UI()
        {
            InitializeComponent();
        }

        private void searchui_home_button_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void home_button_Click(object sender, EventArgs e)
        {
            HomePage suihomepage = new HomePage();
            suihomepage.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void search_button_Click(object sender, EventArgs e)
        {
            
            string location = loc_comboBox.Text;
            int min = Convert.ToInt32(min_textBox);
            int max = Convert.ToInt32(max_textBox);

            bool gasline = checkBox_gas.Checked;
            bool water = checkBox_water.Checked;
            bool park = checkBox_park.Checked;
            bool lake = checkBox_lake.Checked;
            bool electricity = checkBox_electricity.Checked;
            bool security = checkBox_security.Checked;
            bool elevator = checkBox_elevator.Checked;
            bool market = checkBox_market.Checked;
            bool religious = checkBox_religious.Checked;
            bool education = checkBox_education.Checked;
            bool parking = checkBox_parking.Checked;
            bool intercom = checkBox_intercom.Checked;
            bool cleaning = checkBox_cleaning.Checked;
            bool maintenance = checkBox_maintenance.Checked;

            foreach(property p in utility.allproperties)
            {
                if(Convert.ToInt32(p.rent) >= min && Convert.ToInt32(p.rent) <= max)
                {
                    bool includeProperty = true;
                    if(checkBox_gas.Checked && !p.Gasline)
                    {
                        includeProperty= false;
                    }
                    if(checkBox_water.Checked && !p.Water)
                    {
                        includeProperty= false;
                    }
                    if (checkBox_park.Checked && !p.Park)
                    {
                        includeProperty = false;
                    }
                    if (checkBox_lake.Checked && !p.Lake)
                    {
                        includeProperty = false;
                    }
                    if (checkBox_electricity.Checked && !p.Electricity)
                    {
                        includeProperty = false;
                    }
                    if (checkBox_security.Checked && !p.Security)
                    {
                        includeProperty = false;
                    }
                    if (checkBox_elevator.Checked && !p.Elevator)
                    {
                        includeProperty = false;
                    }
                    if (checkBox_market.Checked && !p.Market)
                    {
                        includeProperty = false;
                    }
                    if (checkBox_religious.Checked && !p.Religious)
                    {
                        includeProperty = false;
                    }
                    if (checkBox_education.Checked && !p.Education)
                    {
                        includeProperty = false;
                    }
                    if (checkBox_parking.Checked && !p.Parking)
                    {
                        includeProperty = false;
                    }
                    if (checkBox_intercom.Checked && !p.Intercom)
                    {
                        includeProperty = false;
                    }
                    if (checkBox_cleaning.Checked && !p.Cleaning)
                    {
                        includeProperty = false;
                    }
                    if (checkBox_maintenance.Checked && !p.Maintenance)
                    {
                        includeProperty = false;
                    }

                    if(includeProperty)
                    {
                        propertyList.Add(p);

                    }
                }
            }
        }
    }
}
