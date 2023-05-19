using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace OOP_Project_HOR
{
    public partial class add_property : Form


    {
        
        static string Path = @"D:\hor\";


        public add_property()
        {
            InitializeComponent();
        }

        private void add_property_Load(object sender, EventArgs e)
        {

        }

        private void name_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void home_button_Click(object sender, EventArgs e)
        {

            HomePage h1 = new HomePage();
            h1.Show();
            this.Hide();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string name = name_textBox.Text;
            string city = city_textBox.Text;
            string location = loc_comboBox.Text;
            string room = room_comboBox.Text;
            string mas_bed = mas_comboBox.Text;
            string bath = bath_comboBox.Text;
            string balcony = bal_comboBox.Text;
            string size = FlatSize_textBox.Text;
            string rent = rent_textBox.Text;
            
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
            bool maintenance = checkBox_maintaince.Checked;
            property p = new property(location, name, city, room, mas_bed, bath, balcony, size, rent, gasline, water, park, lake, electricity, security, elevator, market, religious, education, parking, intercom, cleaning, maintenance);
            utility.properties.Add(p);

            StreamWriter sw = File.AppendText(utility.currentdir + "properties.txt");
            string q = $"{name},{city},{location},{room},{mas_bed},{bath},{balcony},{size},{rent},{gasline},{water},{park},{lake},{electricity},{security},{elevator},{market},{religious},{education},{parking},{intercom},{cleaning},{maintenance}";
            sw.WriteLine(q); ;
            sw.Close();

            StreamWriter sw1 = File.AppendText(utility.folderdir + "All Properties.txt");
            string q1 = $"{name},{city},{location},{room},{mas_bed},{bath},{balcony},{size},{rent},{gasline},{water},{park},{lake},{electricity},{security},{elevator},{market},{religious},{education},{parking},{intercom},{cleaning},{maintenance}";
            sw1.WriteLine(q1); ;
            sw1.Close();

            MessageBox.Show("Property added successfully!");

            HomePage ap2h= new HomePage();
            ap2h.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
