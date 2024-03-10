using Enum_Ex03.Entities.Enum;
using Enum_Ex03.Entities;
using System;

namespace Enum_Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime moment = DateTime.Now;

            Console.WriteLine("Enter client data: ");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());

            Order order = new Order(moment, status, client);

            Console.Write("How many items to this order ?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine($"Enter #{n} item data: ");

                Console.Write("Product name: ");
                string productName = Console.ReadLine();

                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(quantity, productPrice, product);

                order.addItem(orderItem);
            }

            Console.WriteLine("ORDER SUMMARY: ");

            Console.WriteLine($"Order Moment: {order.Moment}");
            Console.WriteLine($"Order Status: {order.Status}");
            Console.WriteLine($"Client: {client.Name} {client.BirthDate.Year} - {client.Email}");

            Console.WriteLine("ORDER ITEMS: ");
            
            foreach (OrderItem item in order.Item)
            {
                Console.WriteLine($"{item.Product.Name}, ${item.Price}, Quantity: {item.Quantity}, SubTotal: {item.SubTotal()}");
            }

            Console.WriteLine($"Total price: {order.Total()}");
        }
    }
}
