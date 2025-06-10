using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Classes___Inheritance
{
    public class Microwave : Appliance
    {
        double capacity;
        string roomType;
        public Microwave()
        {
             
        }

        public Microwave(
            long itemNumber,
            string name,
            int quantity,
            double wattage,
            string color,
            double price,
            double capacity,
            string roomType) : base(itemNumber, name, quantity, wattage, color, price)
        {
            this.capacity = capacity;   
            this.roomType = roomType;   
        }

        public double Capacity { get => capacity; set => capacity = value; }
        public string RoomType { get => roomType; set => roomType = value; }
    }
}
