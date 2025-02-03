using System;
using OrderProgram.Entities;
using OrderProgram.Entities.Enums;

namespace OrderProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter cliente data");
            Console.Write("Name: ");
            string name = Console.ReadLine() ?? "";

            Console.Write("Email: ");
            string email = Console.ReadLine() ?? "";

            Console.Write("Birthdate (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine() ?? "");

            Client client = new Client(name, email, birthDate);
            Console.WriteLine();

            Console.WriteLine("Enter order data");
            Console.Write("Status  (PendingPayment, Processing, Shipped, Delivered): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine() ?? "");
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int count_items;
            count_items = int.TryParse(Console.ReadLine(), out count_items) ? count_items : 0;

            for (int i = 0; i < count_items; i++) {
                Console.WriteLine();
                Console.WriteLine($"Enter #{i+1} item data");
                Console.Write("Product name: ");
                string productName = Console.ReadLine() ?? "";

                Console.Write("Product price: ");
                double productPrice;
                productPrice = double.TryParse(Console.ReadLine(), out productPrice) ? productPrice : 0;
                Product product = new Product(productName, productPrice);               

                Console.Write("Quantity: ");
                int product_quantity;
                product_quantity = int.TryParse(Console.ReadLine(), out product_quantity) ? product_quantity : 0;
                OrderItem orderItem = new OrderItem(product_quantity, product);
                order.AddItem(orderItem);             
            }

            Console.WriteLine();
            Console.WriteLine(order);
        }
    }
}