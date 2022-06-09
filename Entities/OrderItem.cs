using System.Text;
namespace Course.Entities
{
   class OrderItem
   {
        public double Price {get; private set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(double price, int quantity, Product product)
        {
            Price = price;
            Quantity = quantity;
            Product = product;
        }
        
        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            StringBuilder sd = new StringBuilder();
            sd.Append(Product.Name);
            sd.Append(", $");
            sd.Append(Price.ToString("F2"));
            sd.Append(", Quantity: ");
            sd.Append(Quantity);
            sd.Append(", Subtotal: $");
            sd.Append(SubTotal().ToString("F2"));
            return sd.ToString();
        }
    }
}