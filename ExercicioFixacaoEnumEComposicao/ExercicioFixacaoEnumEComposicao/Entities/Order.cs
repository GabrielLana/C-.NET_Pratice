using ExercicioFixacaoEnumEComposicao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoEnumEComposicao.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
            Moment = DateTime.Now;
        }

        public Order(Client client, OrderStatus status) : base()
        {
            Moment = DateTime.Now;
            Client = client;
            Status = status;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        private double Total()
        {
            double sum = 0;
            foreach (OrderItem item in Items)
            {
                sum += item.Price;
            }

            return sum;
        }

        public void UpdateStatus(OrderStatus status) 
        {
            Status = status;
        }

        public override string ToString() 
        { 
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("ORDER SUMMARY");
            sb.AppendLine($"Order moment: {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            sb.AppendLine($"Order status: {Status.ToString()}");
            sb.AppendLine($"Client: {Client.Name} ({Client.BirthDate.ToString("dd/MM/yyyy")}) - {Client.Email}");
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine($"{item.Product.Name}, ${item.Product.Price.ToString("F2")}, Quantity: {item.Quantity}, Subtotal: ${item.Price.ToString("F2")}");
            }
            sb.AppendLine($"Total price: ${Total().ToString("F2")}");

            return sb.ToString();
        }
    }
}
