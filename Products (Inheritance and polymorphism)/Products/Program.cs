using Products.Entities;
using System;

namespace Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int product_count = 0;
            int.TryParse(Console.ReadLine(), out product_count);

            for (int i = 0; i < product_count; i++) {
                Console.WriteLine();
                Console.WriteLine($"Product #{i + 1} data:");

                Console.Write("Common, usedorimported(c/u/i)? ");
                string type = Console.ReadLine() ?? "";

                Console.Write("Name: ");
                string name = Console.ReadLine() ?? "";

                Console.Write("Price: ");
                double price = 0.0;
                double.TryParse(Console.ReadLine(), out price);

                switch (type) {
                    case "c":
                        products.Add(new Product(name, price));

                        break;
                    case "i":
                        Console.Write("Customs fee: ");
                        double customsFee = 0.0;
                        double.TryParse(Console.ReadLine(), out customsFee);
                        products.Add(new ImportedProduct(name, price, customsFee));

                        break;
                    case "u":
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime manufac_date = DateTime.Parse(Console.ReadLine() ?? "00/00/0000");
                        products.Add(new UsedProduct(name, price, manufac_date));

                        break;
                    default:
                        Console.WriteLine("Wrong type.");
                        return;                       
                }
            }

            Console.WriteLine();
            Console.WriteLine("Price TAGS:");
            foreach (Product product in products) {
                Console.WriteLine(product.PriceTag());
            }
            

        }
    }
}