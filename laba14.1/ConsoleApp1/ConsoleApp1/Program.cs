using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        public class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
        }

        public class Seller
        {
            public string Name { get; set; }
        }

        public class Shop
        {
            private List<Product> products = new List<Product>();
            private Seller seller;

            public Shop(Seller seller)
            {
                this.seller = seller ?? throw new Exception("Продавец не может быть null");
            }

            public void AddProduct(Product product)
            {
                if (products.Any(p => p.Name == product.Name))
                    throw new Exception("Товар уже существует в магазине");

                products.Add(product);
            }

            public void SellProduct(string productName, decimal payment)
            {
                var product = products.FirstOrDefault(p => p.Name == productName);

                if (product == null)
                    throw new Exception("Товар не найден");

                if (payment < product.Price)
                {
                    throw new Exception("Недостаточно денег для покупки товара");
                }

                products.Remove(product);
            }

            public void Liquidate()
            {
                if (products.Any())
                    throw new Exception("Магазин не может быть ликвидирован, пока в нем есть товары");

                // Ликвидация магазина
            }
        }

    }
}

