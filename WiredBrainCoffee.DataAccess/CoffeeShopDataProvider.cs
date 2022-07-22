

using WiredBrainCoffee.DataAccess.Model;

namespace WiredBrainCoffee.DataAccess
{
    public class CoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> LoadCoffeeShops()
        {
            yield return new CoffeeShop
            {
                Location = "Lapu-Lapu",
                BeansInStockInKg = 107,
                PaperCupsInStock = 23
            };
            yield return new CoffeeShop
            {
                Location = "Cordova",
                BeansInStockInKg = 120,
                PaperCupsInStock = 12

            };
            yield return new CoffeeShop
            {
                Location = "Lapu-Lapu",
                BeansInStockInKg = 56,
                PaperCupsInStock = 22
            };

        }
    }
}
