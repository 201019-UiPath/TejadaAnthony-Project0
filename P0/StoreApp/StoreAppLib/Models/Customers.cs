using System;

namespace StoreAppLib
{
    public class Customers
    {

        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public int CustomerId { get; set; } //primary key
        
        public Customers(int customerid, int age, string email, string name){

            Name=name;
            Email=email;
            Age=age;
            CustomerId=customerid;
        }
    }
}
