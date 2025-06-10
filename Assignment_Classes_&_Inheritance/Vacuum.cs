using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Classes___Inheritance
{
    public class Vacuum : Appliance
    {
        string grade;
        int batteryVoltage;
        public Vacuum()
        {
             
        }

        public Vacuum(
            long itemNumber,
            string name,
            int quantity,
            double wattage,
            string color,
            double price,
            string grade,
            int batteryVoltage) : base(itemNumber, name, quantity, wattage, color, price)
        {
            this.grade = grade;
            this.batteryVoltage = batteryVoltage;
            
        }

        public string Grade { get => grade; set => grade = value; }
        public int BatteryVoltage { get => batteryVoltage; set => batteryVoltage = value; }
    }
}
