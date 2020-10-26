using System;

namespace StoreAppLib
{
    public class Customers
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public int CustomerId { get; set; } //primary key

        public Customers(string name, string email, string password, int age, int customerId)
        {
            this.Name = name;
            this.Email = email;
            this.Password = password;
            this.Age = age;
            this.CustomerId = customerId;

        }

    }
}
