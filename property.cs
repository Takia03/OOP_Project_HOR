using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



        public property( string location,string name,string city,string room,string mas_bed,string bath,string balcony,string size, string rent) 
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
        }
        public void hudai()
        { }
    }
}
