using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Classes___Inheritance
{
    public class Dishwasher : Appliance
    {
        string soundRating;
        string feature;
        public Dishwasher()
        {
             
        }

        public Dishwasher(long itemNumber,
                          string name,
                          int quantity,
                          double wattage,
                          string color,
                          double price,
                          string soundRating,
                          string feature) : base(itemNumber, name, quantity, wattage, color, price)
        {
            this.soundRating = soundRating; 
            this.feature = feature; 
        }

        public string SoundRating { get => soundRating; set => soundRating = value; }
        public string Feature { get => feature; set => feature = value; }
    }
}
