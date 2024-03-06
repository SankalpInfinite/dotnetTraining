using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment
{
    public class assessment2Product
    {
       
        public int ProductID;
        public string ProductName;
        public decimal Price;
    }

    class abc
    {
        static void Main(string[] args)
        {
            
            List<assessment2Product> products = new List<assessment2Product>();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Enter details for Product {i}:");
                Console.Write("Product ID: ");
                int productId = int.Parse(Console.ReadLine());

                Console.Write("Product Name: ");
                string productName = Console.ReadLine();

                Console.Write("Price: ");
                decimal price = decimal.Parse(Console.ReadLine());

                products.Add(new assessment2Product
                {
                    ProductID = productId,
                    ProductName = productName,
                    Price = price
                });
            }

            products = products.OrderBy(p => p.Price).ToList();

            Console.WriteLine("\nSorted Products (by price):");
            foreach (var product in products)
            {
                Console.WriteLine($"Product ID: {product.ProductID}, Name: {product.ProductName}, Price: {product.Price:C}");
            }
        }
    }
}
