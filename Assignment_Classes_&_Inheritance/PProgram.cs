using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_Classes___Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Appliance>appliances = new List<Appliance>();
            string Path = "..\\..\\Res\\TextFile1.txt"; //ReadFile
            string[] lines = File.ReadAllLines(Path);
            foreach (string line in lines)
            {
                string[] fields = line.Split(';');
                long itemNumber = long.Parse(fields[0]);
                string name = fields[1];
                int quantity = int.Parse(fields[2]);
                double wattage = double.Parse(fields[3]);
                string color = fields[4];
                double price = double.Parse(fields[5]);

                int firstDigit = int.Parse(Math.Abs(itemNumber).ToString()[0].ToString());

                if (firstDigit == 1)
                {
                    int numberOfDoors = int.Parse(fields[6]);
                    int height = int.Parse(fields[7]);
                    int width = int.Parse(fields[8]);
                    appliances.Add(new Refrigerator(itemNumber, name,
                        quantity, wattage, color, price, numberOfDoors, height, width));
                }
                else if (firstDigit == 2) 
                {

                }
            }



            static void SaveToFile(List<Appliance> appliances, string filePath)
            {
                List<string> lines = new List<string>();

                foreach (Appliance a in appliances)
                {
                    switch (a)
                    {
                        case Refrigerator r:
                            lines.Add($"{r.ItemNumber};{r.Brand};{r.Quantity};{r.Wattage};{r.Color};{r.Price};{r.NumberOfDoors};{r.Height};{r.Width};");
                            break;

                        case Vacuum v:
                            lines.Add($"{v.ItemNumber};{v.Brand};{v.Quantity};{v.Wattage};{v.Color};{v.Price};{v.Grade};{v.BatteryVoltage};");
                            break;

                        case Microwave m:
                            lines.Add($"{m.ItemNumber};{m.Brand};{m.Quantity};{m.Wattage};{m.Color};{m.Price};{m.Capacity};{m.RoomType};");
                            break;

                        case Dishwasher d:
                            lines.Add($"{d.ItemNumber};{d.Brand};{d.Quantity};{d.Wattage};{d.Color};{d.Price};{d.Feature};{d.SoundRating};");
                            break;
                    }
                }

                File.WriteAllLines(filePath, lines);
                Console.WriteLine(" Data saved successfully.");
            }

        }
    }
}
