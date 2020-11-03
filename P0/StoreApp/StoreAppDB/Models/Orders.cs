using System.ComponentModel.DataAnnotations.Schema;

namespace StoreAppDB.Models
{
    public class Orders
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; } //Primary key
        public string OrderDate { get; set; }
        public int LocationId{get; set; }
        public Location Location{ get; set; } 
        public Customer Customer { get; set; } 
        public int CustomerId{get; set; }
        public int Cost { get; set; }

    }
}