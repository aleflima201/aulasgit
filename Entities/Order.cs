using System.Text;
using Course.Entities.Enums;

namespace Course.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(OrderStatus status, Client client)
        {
            Moment = DateTime.Now;
            Status = status;
            Client = client;
        }

        public void AddItems(OrderItem items)
        {
            Items.Add(items);
        }
        public void RemoveItems(OrderItem items)
        {
            Items.Remove(items);
        }
        public double Total()
        {   
            double sum = 0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sd = new StringBuilder();
            sd.Append("Order moment: ");
            sd.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sd.Append("Order status: ");
            sd.AppendLine(Status.ToString());
            sd.Append("Client: ");
            sd.Append(Client.Name);
            sd.Append(" (");
            sd.Append(Client.BirthDate.ToString("dd/MM/yyyy"));
            sd.Append(") - ");
            sd.AppendLine(Client.Email);
            sd.AppendLine("Order Items:");
            foreach (OrderItem item in Items)
            {
                sd.AppendLine(item.ToString());
            }
            sd.Append("Total price: $");
            sd.Append(Total().ToString("F2"));

            return sd.ToString();
        }
    }
}