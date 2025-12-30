using DataTier;
using System.Collections.Generic;
using System.Linq;

namespace LogicTier
{
    public class ShopService
    {
        public double TotalProfit { get; }
        public List<ProductItem> Items { get; }
        public Dictionary<string, double> AveragePurchasePriceByGroup { get; }

        public ShopService(string dataPath)
        {
            var products = new ProductRepository().LoadProducts(dataPath);
            Items = products.Select(p => new ProductItem(p)).ToList();
            TotalProfit = Items.Sum(p => p.Profit);

            AveragePurchasePriceByGroup = Items
                .GroupBy(p => p.Group)
                .ToDictionary(g => g.Key, g => g.Average(p => p.PurchasePrice));
        }
    }
}