// See https://aka.ms/new-console-template for more information
using System.Linq;
using WiredBrainCoffee.DataAccess;
using WiredBrainCoffee.ShopInfoToolNew;

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
    ICommandHandler commandHandler = string.Equals("help", line, StringComparison.OrdinalIgnoreCase) ?
    new HelpCommandHandler(coffeeShops) as ICommandHandler
    : new CoffeeCommandHandler(coffeeShops, line);

    commandHandler.HandleCommand();


}