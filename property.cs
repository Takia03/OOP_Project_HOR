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
        
        public bool Gasline { get; set; }
        public bool Water{ get; set; }
        public bool Park { get; set; }
        public bool Lake { get; set; }
        public bool Electricity { get; set; }
        public bool Security { get; set; }
        public bool Elevator { get; set; }
        public bool Market { get; set; }
        public bool Religious { get; set; }
        public bool Education { get; set; }
        public bool Parking { get; set; }
        public bool Intercom { get; set; }
        public bool Cleaning { get; set; }
        public bool Maintenance { get; set; }
        public user users { get; set; }



        public property( string location,string name,string city,string room,string mas_bed,string bath,string balcony,string size, string rent, bool gas, bool water, bool park, bool lake, bool electricity, bool security, bool elevator, bool market, bool religious, bool education, bool parking, bool intercom, bool cleaning, bool maintenance) 
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
