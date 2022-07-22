

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
                PaperCupsInStock = 233
            };
            yield return new CoffeeShop
            {
                Location = "Cordova",
                BeansInStockInKg = 120,
                PaperCupsInStock = 200

            };
            yield return new CoffeeShop
            {
                Location = "Lapu-Lapu",
                BeansInStockInKg = 56,
                PaperCupsInStock = 100
            };

        }
    }
}
