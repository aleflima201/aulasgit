using System;
using Course.Entities;
using Course.Entities.Enums;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/DDDD): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, date);

            Console.WriteLine("\nEnter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());
                Product product = new Product(nameProduct, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                OrderItem item = new OrderItem(price, quantity, product);
                order.AddItems(item);                
            }
            
            Console.WriteLine("\nORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}