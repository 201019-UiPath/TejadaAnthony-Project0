using System.Net.Http.Headers;
namespace StoreAppDB.Models
{
    public class Inventory
    {
        public int InventoryId { get; set; } // primary key
        public BaseballBat BaseballBats { get; set; }
        public int Quantity{ get; set; }

    }
}