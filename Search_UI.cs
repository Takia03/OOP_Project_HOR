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
            rayshadboss();
        }

        private void rayshadboss()
        {
            string s = $"Rent(tk)\tRooms\tMaster\tBaths\tBalcony\tSize (sft)\tMobile\t\tName";
            listBox_search_property.Items.Add(s);
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
            propertyList.Clear();
            listBox_search_property.Items.Clear();
            rayshadboss();

            string location = loc_comboBox.Text;
            int min = Convert.ToInt32(min_textBox.Text);
            int max = Convert.ToInt32(max_textBox.Text);

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
               if(p.location == location)
                {
                    if (Convert.ToInt32(p.rent) >= min && Convert.ToInt32(p.rent) <= max)
                    {
                        bool includeProperty = true;
                        if (gasline && !p.Gasline)
                        {
                            includeProperty = false;
                            //MessageBox.Show("Dib shkibidi 3");
                        }
                        if (water && !p.Water)
                        {
                            includeProperty = false;
                            //MessageBox.Show("Dib shkibidi 4");
                        }
                        if (park && !p.Park)
                        {
                            includeProperty = false;
                            //MessageBox.Show("Dib shkibidi 6");
                        }
                        if (lake && !p.Lake)
                        {
                            includeProperty = false;
                            //MessageBox.Show("Dib shkibidi 7");
                        }
                        if (electricity && !p.Electricity)
                        {
                            includeProperty = false;
                            //MessageBox.Show("Dib shkibidi 8");
                        }
                        if (security && !p.Security)
                        {
                            includeProperty = false;
                            //MessageBox.Show("Dib shkibidi 9");
                        }
                        if (elevator && !p.Elevator)
                        {
                            includeProperty = false;
                            //MessageBox.Show("Dib shkibidi 10");
                        }
                        if (market && !p.Market)
                        {
                            includeProperty = false;
                            //MessageBox.Show("Dib shkibidi 11");
                        }
                        if (religious && !p.Religious)
                        {
                            includeProperty = false;
                            //MessageBox.Show("Dib shkibidi 12");
                        }
                        if (education && !p.Education)
                        {
                            includeProperty = false;
                            //MessageBox.Show("Dib shkibidi 13");
                        }
                        if (parking && !p.Parking)
                        {
                            includeProperty = false;
                            //MessageBox.Show("Dib shkibidi parking");
                        }
                        if (intercom && !p.Intercom)
                        {
                            includeProperty = false;
                            //MessageBox.Show("Dib shkibidi com");
                        }
                        if (cleaning && !p.Cleaning)
                        {
                            includeProperty = false;
                            //MessageBox.Show("Dib shkibidi clean");
                        }
                        if (maintenance && !p.Maintenance)
                        {
                            includeProperty = false;
                            //MessageBox.Show("Dib shkibidi main");
                        }

                        if (includeProperty)
                        {
                            propertyList.Add(p);
                            string ss = $"{p.rent}\t{p.room}\t{p.mas_bed}\t{p.bath}\t{p.balcony}\t{p.size} sft\t{p.users.mobile}\t{p.name}";
                            listBox_search_property.Items.Add(ss);
                            //MessageBox.Show("Dib shkibidi");
                        }
                    }
                    else
                    {
                        //MessageBox.Show("Dibba");
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomePage suihomepage = new HomePage();
            suihomepage.Show();
            this.Hide();
        }
    }
}
