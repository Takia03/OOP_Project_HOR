using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Windows.Forms;
using System.Runtime.InteropServices.ComTypes;

namespace OOP_Project_HOR
{
    internal class property
    {
        public string name { get; set; }
        public string city { get; set; }
        public string location { get; set; }
        public string room { get; set; }
        public string mas_bed { get; set; }
        public string bath { get; set; }
        public string balcony { get; set; }
        public string size { get; set; }
        public string rent { get; set; }
        
        public string Gasline { get; set; }
        public string Water{ get; set; }
        public string Park { get; set; }
        public string Lake { get; set; }
        public string Electricity { get; set; }
        public string Security { get; set; }
        public string Elevator { get; set; }
        public string Market { get; set; }
        public string Religious { get; set; }
        public string Education { get; set; }
        public string Parking { get; set; }
        public string Intercom { get; set; }
        public string Cleaning { get; set; }
        public string Maintenance { get; set; }



public property( string location,string name,string city,string room,string mas_bed,string bath,string balcony,string size, string rent, string gas, string water, string park, string lake, string electricity, string security,  string elevator, string market, string religious, string education, string parking, string intercom, string cleaning, string maintenance) 
        {
            this.location = location;
            this.room = room;
            this.name = name;
            this.city = city;
            this.mas_bed= mas_bed;
            this.bath= bath;
            this.balcony = balcony;
            this.size = size;
            this.rent = rent;
            this.Gasline= gas;
            this.Water= water;
            this.Park= park;
            this.Lake= lake;
            this.Electricity= electricity;
            this.Security= security;
            this.Elevator= elevator;
            this.Market= market;
            this.Religious= religious;
            this.Education= education;
            this.Parking= parking;
            this.Intercom= intercom;
            this.Cleaning = cleaning;
            this.Maintenance= maintenance;
        }

    }
}
