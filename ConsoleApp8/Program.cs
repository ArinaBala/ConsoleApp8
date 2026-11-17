using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp8
{
    class Product
    {
        public string Name 
        {
            get;
            set;
        }
        public string Category 
        {
            get;
            set;
        }
        public string Brand 
        {
            get;
            set;
        }
        public decimal Price 
        {
            get;
            set;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product { Name = "iPhone 15", Category = "Smartphones", Brand = "Apple", Price = 35000 },
                new Product { Name = "iPhone 14", Category = "Smartphones", Brand = "Apple", Price = 28000 },
                new Product { Name = "Samsung S24", Category = "Smartphones", Brand = "Samsung", Price = 32000 },
                new Product { Name = "Samsung A55", Category = "Smartphones", Brand = "Samsung", Price = 15000 },

                new Product { Name = "MacBook Air", Category = "Laptops", Brand = "Apple", Price = 45000 },
                new Product { Name = "MacBook Pro", Category = "Laptops", Brand = "Apple", Price = 75000 },
                new Product { Name = "Lenovo ThinkPad", Category = "Laptops", Brand = "Lenovo", Price = 38000 },
                new Product { Name = "Lenovo IdeaPad", Category = "Laptops", Brand = "Lenovo", Price = 25000 },

                new Product { Name = "Samsung TV", Category = "TV", Brand = "Samsung", Price = 29000 },
                new Product { Name = "LG OLED", Category = "TV", Brand = "LG", Price = 55000 },

                new Product { Name = "AirPods", Category = "Accessories", Brand = "Apple", Price = 8000 },
                new Product { Name = "Galaxy Buds", Category = "Accessories", Brand = "Samsung", Price = 5000 },
                new Product { Name = "Logitech Mouse", Category = "Accessories", Brand = "Logitech", Price = 1500 },
                new Product { Name = "Logitech Keyboard", Category = "Accessories", Brand = "Logitech", Price = 2500 }
            };

            Console.WriteLine("1");
            var brandCounts = products.GroupBy(p => p.Brand);
            foreach (var group in brandCounts)
            {
                Console.WriteLine($"{group.Key}: {group.Count()}");
            }
            Console.WriteLine();

            Console.WriteLine("2");
            var categoryAvgPrices = products.GroupBy(p => p.Category);
            foreach (var group in categoryAvgPrices)
            {
                decimal avgPrice = Math.Round(group.Average(p => p.Price), 2);
                Console.WriteLine($"{group.Key}: {avgPrice}");
            }
            Console.WriteLine();

            Console.WriteLine("3");
            var brandMaxProducts = products.GroupBy(p => p.Brand);
            foreach (var group in brandMaxProducts)
            {
                var maxProduct = group.OrderByDescending(p => p.Price).First();
                Console.WriteLine($"{group.Key} - {maxProduct.Name} ({maxProduct.Price})");
            }
        }
    }
}