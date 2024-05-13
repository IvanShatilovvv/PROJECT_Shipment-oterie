namespace ShipmentСoterie.Tables
{
    public class OrderList
    {
        public int id { get; set; }
        public Order order { get; set; }
        public int orderId { get; set; }
        public Product product { get; set; }
        public int productId { get; set; }

        public OrderList()
        {
            
        }
    }
}
