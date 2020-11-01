using StoreAppDB.Models;
using System.Collections.Generic;
namespace StoreAppDB.Interfaces
{
    public interface ICustomerRepoActions
    {
         bool CheckIfCustomerExists(string email, string password );
        void AddCustomerIntoTable(Customer newCustomer);
    }
}