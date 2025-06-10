using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Classes___Inheritance
{
    public class Refrigerator : Appliance
    {
        int numberOfDoors;
        int height;
        int width;
        public Refrigerator()
        {
             
        }

        public Refrigerator(
            long itemNumber,
            string name,
            int quantity,
            double wattage,
            string color,
            double price,
            int numberOfDoors,
            int height,
            int width) : base(itemNumber, name, quantity, wattage, color, price)
        {

            this.NumberOfDoors = numberOfDoors;
            this.Height = height;
            this.Width = width;

        }


    

        public int NumberOfDoors { get => numberOfDoors; set => numberOfDoors = value; }
        public int Height { get => height; set => height = value; }
        public int Width { get => width; set => width = value; }
    }
}
