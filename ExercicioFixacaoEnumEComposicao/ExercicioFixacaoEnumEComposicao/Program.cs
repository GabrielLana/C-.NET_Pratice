using ExercicioFixacaoEnumEComposicao.Entities;
using ExercicioFixacaoEnumEComposicao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercicioFixacaoEnumEComposicao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Client client = new Client(); 

            Console.WriteLine("Enter client data:");
            Console.Write("Name: "); client.Name = Console.ReadLine();
            Console.Write("Email: "); client.Email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): "); client.BirthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            Order order = new Order(client, Enum.Parse<OrderStatus>(Console.ReadLine()));
            Console.Write("How many items to this order? "); int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Product product = new Product();

                Console.WriteLine($"Enter #{i + 1} item data:");
                Console.Write("Product name: "); product.Name = Console.ReadLine();
                Console.Write("Product price: $"); product.Price = double.Parse(Console.ReadLine());
                Console.Write("Quantity: "); int quantity = int.Parse(Console.ReadLine());
                
                OrderItem item = new OrderItem(quantity, product);
                order.AddItem(item);
            }

            Console.WriteLine(order.ToString());

        }
    }
}
