using System.Net.Mime;
using System.Collections.Generic;
namespace StoreAppDB.Models
{
    public class Location
    {
        public int LocationId { get; set; } //primary key
        public string LocationName { get; set; }
        public Manager Manager{ get; set; } //foreign key
        public List<Inventory> Inventory { get; set; }



    }
}