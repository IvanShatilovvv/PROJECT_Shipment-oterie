namespace ShipmentСoterie.Tables
{
    public class User
    {
        public int Id { get; set; }
        public Role role { get; set; }
        public int roleId { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public Profile profile { get; set; }
        public int profileId { get; set; }

        public User()
        {
            
        }
    }
}