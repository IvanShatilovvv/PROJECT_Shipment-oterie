namespace ShipmentСoterie.Tables
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public Shop shop { get; set; }
        public int shopId { get; set; }
        public string description { get; set; }
        public string photo { get; set; }
        public ProductType type { get; set; }
        public int typeId { get; set; }
        public float price { get; set; }

        public Product()
        {
            
        }
    }
}