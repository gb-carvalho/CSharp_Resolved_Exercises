using OrderProgram.Entities.Enums;
using System.Text;

namespace OrderProgram.Entities
{
    internal class Order
    {
        DateTime Moment { get; set; } = DateTime.Now;
        OrderStatus Status { get; set; }
        Client Client { get; set; }
        List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            OrderItems.Add(item);
        }

        public void RemoveItem(OrderItem item) {
            OrderItems.Remove(item); 
        }

        public double Total()
        {
            double total = 0;
            foreach (OrderItem orderItem in OrderItems)
            {
                total += orderItem.SubTotal();
            }

            return total;   
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine("ORDER Summary");
            sb.AppendLine($"Order Moment: {Moment}");
            sb.AppendLine($"Order status: {Status}");
            sb.AppendLine($"Client: {Client}");
            sb.AppendLine();
            sb.AppendLine("Order Items:");
            foreach (OrderItem orderItem in OrderItems)
            {
                sb.AppendLine(orderItem.ToString());
            }
            sb.AppendLine($"Total price: ${Total():F2}");
            return sb.ToString();
                
        }
    }
}
