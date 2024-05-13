using System.Diagnostics.CodeAnalysis;

namespace ShipmentСoterie.Tables
{
    public class Profile
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string secondName { get; set; } = "";
        public string thirdName { get; set; } = "";
        public int age { get; set; } = 0;
        public string cardNumber { get; set; } = "";
        public string adres { get; set; } = "";
        public string photo { get; set; } = "";
        public float personalDiscount { get; set; } = 0.0f;

        public Profile()
        {
            
        }

    }
}