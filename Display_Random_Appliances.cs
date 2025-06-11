

using System;
static void ShowRandom(List<Appliance> appliances)
{
    Console.Write("Enter number of appliances to display: ");
    if (int.TryParse(Console.ReadLine(), out int count))
    {
        var random = new Random();
        var selected = appliances.OrderBy(x => random.Next()).Take(count);

        foreach (var a in selected)
        {
            Console.WriteLine(a);
            Console.WriteLine("---------------");
        }
    }
    else
    {
        Console.WriteLine("Invalid number.");
    }
}