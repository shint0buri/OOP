using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace lab16
{
    public class DataStorage
    {
        private List<RawDataItem> _rawData = new List<RawDataItem>();
        private List<SummaryDataItem> _summaryData = new List<SummaryDataItem>();
        private readonly char _delimiter = ';';

        public bool InitData(string filePath)
        {
            try
            {
                var lines = File.ReadAllLines(filePath);
                _rawData.Clear();

                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    var parts = line.Split(_delimiter);
                    if (parts.Length < 4) continue; 

                    var name = parts[0].Trim();
                    var group = parts[1].Trim();
                    var priceStr = parts[2].Trim();
                    var warehouse = parts[3].Trim();


                    if (!double.TryParse(priceStr, System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture, out double price))
                    {
                        continue;
                    }

                    _rawData.Add(new RawDataItem
                    {
                        Name = name,
                        Group = group,
                        Price = price,
                        Warehouse = warehouse
                    });
                }

                return _rawData.Count > 0;
            }
            catch
            {
                return false;
            }
        }

        public void BuildSummary()
        {
            var avgByWarehouse = _rawData
                .GroupBy(x => x.Warehouse)
                .Select(g => new SummaryDataItem
                {
                    Category = "Склад",
                    Name = g.Key,
                    Value = Math.Round(g.Average(x => x.Price), 2)
                });

            var sumByGroup = _rawData
                .GroupBy(x => x.Group)
                .Select(g => new SummaryDataItem
                {
                    Category = "Группа",
                    Name = g.Key,
                    Value = Math.Round(g.Sum(x => x.Price), 2)
                });

            _summaryData = avgByWarehouse.Concat(sumByGroup).ToList();
        }

        public List<RawDataItem> GetRawData() => _rawData;
        public List<SummaryDataItem> GetSummaryData() => _summaryData;
    }
}