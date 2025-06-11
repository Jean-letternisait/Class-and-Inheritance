using System;
static void FindByBrand(List<Appliance> appliances)
{
    Console.Write("Enter brand to search for: ");
    string brand = Console.ReadLine();

    var matches = appliances.Where(a => a.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase));

    if (!matches.Any())
    {
        Console.WriteLine("No appliances found for that brand.");
    }
    else
    {
        Console.WriteLine("Matching Appliances:");
        foreach (var appliance in matches)
        {
            Console.WriteLine(appliance);
            Console.WriteLine("--------------------");
        }
    }
}
