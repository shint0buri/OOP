using datatier;
using DataTier;

namespace LogicTier
{
    public class ProductItem
    {
        private readonly Product _product;

        public ProductItem(Product product) => _product = product;

        public string Name => _product.Name;
        public string Group => _product.Group;
        public double PurchasePrice => _product.PurchasePrice;
        public double SalePrice => _product.SalePrice;
        public double Profit => SalePrice - PurchasePrice;
        public string Display => $"{Name} ({Group}) — закуп: {PurchasePrice:F2}, продажа: {SalePrice:F2}";
    }
}