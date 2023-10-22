using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoEnumEComposicao.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem() { }

        public OrderItem(int quantity, Product product) 
        {
            Quantity = quantity;
            Product = product;
            Price = SubTotal();
        }

        private double SubTotal()
        {
            return Quantity * Product.Price;
        }
    }
}
