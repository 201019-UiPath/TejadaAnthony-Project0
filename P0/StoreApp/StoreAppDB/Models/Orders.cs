namespace StoreAppDB.Models
{
    public class Orders
    {

        public string Id { get; set; } //Primary key
        public string OrderDate { get; set; }
        public Location Location{ get; set; } 
        public Customer Customer { get; set; } 
        public int Cost { get; set; }

    }
}