using System;
using System.Data.SqlTypes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreAppDB.Models
{
    public class Orders
    {
       
       
        public Int16  Id { get; set; } //Primary key
        public string OrderDate { get; set; }
        public int LocationId{get; set; }
        public Location Location{ get; set; } 
        public Customer Customer { get; set; } 
        public int CustomerId{get; set; }
        public int Cost { get; set; }

    }
}