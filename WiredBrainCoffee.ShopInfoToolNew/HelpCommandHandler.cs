// See https://aka.ms/new-console-template for more information
using WiredBrainCoffee.DataAccess.Model;

namespace WiredBrainCoffee.ShopInfoToolNew
{
    internal class HelpCommandHandler : ICommandHandler
    {
        private IEnumerable<CoffeeShop> coffeeShops;

        public HelpCommandHandler(IEnumerable<CoffeeShop> coffeeShops)
        {
            this.coffeeShops = coffeeShops;
        }

        public void HandleCommand()
        {
            Console.WriteLine("> Available coffee shop commands: ");
            foreach (var coffeeShop in coffeeShops)
            {
                Console.WriteLine($"> " + coffeeShop.Location);
            }
        }
    }
}