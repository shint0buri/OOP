using datatier;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace DataTier
{
    public class ProductRepository
    {
        public List<Product> LoadProducts(string filePath)
        {
            var products = new List<Product>();

            if (!File.Exists(filePath))
            {
                System.Diagnostics.Debug.WriteLine("⚠️ Файл не найден: " + filePath);
                return products;
            }

            var lines = File.ReadAllLines(filePath);
            var culture = CultureInfo.InvariantCulture;

            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i].Trim();
                if (string.IsNullOrEmpty(line)) continue;

                var parts = line.Split(',');
                if (parts.Length != 4)
                {
                    System.Diagnostics.Debug.WriteLine($"⚠️ Неверный формат строки {i + 1}: '{line}'");
                    continue;
                }

                if (double.TryParse(parts[2].Trim(), NumberStyles.Float, culture, out double purchase) &&
                    double.TryParse(parts[3].Trim(), NumberStyles.Float, culture, out double sale))
                {
                    products.Add(new Product
                    {
                        Name = parts[0].Trim(),
                        Group = parts[1].Trim(),
                        PurchasePrice = purchase,
                        SalePrice = sale
                    });
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"⚠️ Ошибка парсинга цен в строке {i + 1}: '{line}'");
                }
            }

            System.Diagnostics.Debug.WriteLine($"✅ Загружено товаров: {products.Count}");
            return products;
        }
    }
}