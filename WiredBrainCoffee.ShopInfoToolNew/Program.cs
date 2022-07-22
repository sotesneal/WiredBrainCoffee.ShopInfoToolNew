// See https://aka.ms/new-console-template for more information
using System.Linq;
using WiredBrainCoffee.DataAccess;

Console.WriteLine("Hello, World!");

Console.WriteLine("Wired Brain Coffee Shop Info Tool!");
Console.WriteLine("Write 'help' to list available coffee commands or quit to end commands ");

var coffeeShopDataProvider = new CoffeeShopDataProvider();
while (true)
{
    var line = Console.ReadLine();
    var coffeeShops = coffeeShopDataProvider.LoadCoffeeShops();
    if (string.Equals("quit", line, StringComparison.OrdinalIgnoreCase))
    {
        break;
    }
    if (string.Equals("help", line, StringComparison.OrdinalIgnoreCase))
    {

        Console.WriteLine("> Available coffee shop commands: ");
        foreach (var coffeeShop in coffeeShops)
        {
            Console.WriteLine($"> " + coffeeShop.Location);
        }
    }
    else
    {
        var foundCoffeeShops = coffeeShops
            .Where(x => x.Location.StartsWith(line, StringComparison.OrdinalIgnoreCase)).ToList();

        if (foundCoffeeShops.Count == 0)
        {
            Console.WriteLine($"> Command '{line}' not found");
        }
        else if (foundCoffeeShops.Count == 1)
        {
            var coffeeShop = foundCoffeeShops.Single();
            Console.WriteLine($"> Location: {coffeeShop.Location}");
            Console.WriteLine($"> Beans in stock: {coffeeShop.BeansInStockInKg} Kg");
        }
        else
        {
            Console.WriteLine($"> Multiple matching coffee shop commands found: ");
            foreach (var coffeeType in foundCoffeeShops)
            {
                Console.WriteLine($"> {coffeeType.Location}");
            }
        }
    
    }
}