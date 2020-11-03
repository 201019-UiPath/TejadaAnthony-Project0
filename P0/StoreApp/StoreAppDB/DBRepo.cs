using System;
using System.Collections.Generic;
using StoreAppDB.Interfaces;
using StoreAppDB.Models;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace StoreAppDB
{
    public class DBRepo : IManagerRepoActions, ICustomerRepoActions, IBaseballBatRepoActions, ILocationRepoActions, IOrderRepoActions, IInventoryRepoActions
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

        public Customer GetCustomerByEmail(string email)
        {
            var result = context.Customers.Single(d => d.Email == email);

            return result;
        }

        //baseballbats
        public List<BaseballBat> GetBaseballBatsByLocation(int id)
        {
            // var result = context.BaseballBats
            //                     .Where

            throw new System.NotImplementedException();
        }
        //locations
        public List<Location> GetAllLocations()
        {
            throw new NotImplementedException();
        }

        public Location GetLocationById(int locationId)
        {
            var result = context.Locations.Single(d => d.LocationId == locationId);

            return result;
        }
        //inventory 
        public void UpdateInventoryQuantity(int batId, int quantity, int locationId)
        {
            throw new NotImplementedException();
        }
        public List<Inventory> GetInventoryByLocationId(int id)
        {
            return context.Inventory.Select(x => x).Where(x => x.LocationId==id).ToList();
        }
        //orders
        public void AddOrderToTable(Orders order)
        {
            throw new NotImplementedException();
        }

        public List<Orders> GetOrdersByIdAndLocation(int id, int locationId)
        {
            throw new NotImplementedException();
        }
        
    }
}