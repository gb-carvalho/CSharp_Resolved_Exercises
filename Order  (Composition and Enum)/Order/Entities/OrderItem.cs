using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProgram.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
            Price = product.Price;
        }

        public double SubTotal() { 
            return Price * Quantity;
        }

        public override string ToString()
        {
            return $"{Product.Name}, ${Product.Price:F2}, Quantity: {Quantity}, Subtotal: ${SubTotal():F2}";
        }
    }
}
