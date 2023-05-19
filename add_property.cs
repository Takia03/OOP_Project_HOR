using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string newpath = Path + "property.txt";
            if(File.Exists(newpath))
            {
                StreamWriter sw = File.AppendText(newpath);
                string q = $"{name_textBox.Text},{city_textBox.Text},{loc_textBox.Text},{room_comboBox.Text},{bal_comboBox.Text},{bath_comboBox.Text},{mas_comboBox.Text},{FlatSize_textBox.Text},{rent_textBox.Text}";
                sw.WriteLine(q);
                sw.Close();


                MessageBox.Show("Added successfully");
                name_textBox.Clear();
                city_textBox.Clear();
                loc_textBox.Clear();
                FlatSize_textBox.Clear();
                rent_textBox.Clear();


                HomePage h1 = new HomePage();
                h1.Show();
                this.Hide();


            }
            else
            {
                File.Create(newpath);

                StreamWriter sw = File.AppendText(newpath);
                string q = $"{name_textBox.Text},{city_textBox.Text},{loc_textBox.Text},{room_comboBox.Text},{bal_comboBox.Text},{bath_comboBox.Text},{mas_comboBox.Text},{FlatSize_textBox.Text},{rent_textBox.Text}";
                sw.WriteLine(q);
                sw.Close();

                MessageBox.Show("Added successfully");
                name_textBox.Clear();
                city_textBox.Clear();
                loc_textBox.Clear();
                FlatSize_textBox.Clear();
                rent_textBox.Clear();


                HomePage h1 = new HomePage();
                h1.Show();
                this.Hide();

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
