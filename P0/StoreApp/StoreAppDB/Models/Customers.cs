using System;

namespace StoreAppDB.Models
{
    public class Customer
    {
        public int CustomerId { get; set; } //primary key
        public string Name { get; set; } 
        public string Email { get; set; }
        public string Password { get; set; }
        


    }
}
