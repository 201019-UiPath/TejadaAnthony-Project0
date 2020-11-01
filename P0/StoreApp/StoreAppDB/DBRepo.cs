using System;
using System.Collections.Generic;
using StoreAppDB.Interfaces;
using StoreAppDB.Models;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace StoreAppDB
{
    public class DBRepo : IManagerRepoActions, ICustomerRepoActions
    {
        private StoreAppContext context = new StoreAppContext();
        public DBRepo(StoreAppContext context)
        {
            this.context = context;
        }

        public void AddBaseballBatIntoTableAsync(BaseballBat baseballbat)
        {
            context.BaseballBats.Add(baseballbat);
            context.SaveChanges();

            
        }

        public List<Orders> GetOrderHistoryByLocation(Location location)
        {
            throw new System.NotImplementedException();
        }

        public bool CheckIfManagerExists(string email, string password)
        {
            var result = context.Managers.Any(o => o.Email == email && o.password == password);

            return result;
        }

        //Customer
        public bool CheckIfCustomerExists(string email, string password)
        {
            var result = context.Customers.Any(o => o.Email == email && o.Password == password);

            return result;
        }

        public void AddCustomerIntoTable(Customer newCustomer)
        {
            context.Customers.Add(newCustomer);
            context.SaveChanges();
        }
    }
}