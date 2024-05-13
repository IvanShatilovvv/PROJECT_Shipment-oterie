namespace ShipmentСoterie.Tables
{
    public class Order
    {
        public int Id { get; set; }
        public User user { get; set; }
        public int userId { get; set; }
        public DateTime date { get; set; }
        public PayMethod payMethod { get; set; }
        public int payMethodId { get; set; }
        public OrderStatus status { get; set; }
        public int statusId { get; set; }

        public Order()
        {
            
        }
    }
}
