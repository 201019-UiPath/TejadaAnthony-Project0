using StoreAppDB.Models;
using System.Collections.Generic;

namespace StoreAppDB.Interfaces
{
    public interface IManagerRepoActions
    {
        void AddBaseballBatIntoTableAsync(BaseballBat baseballbat);
        List<Orders> GetOrderHistoryByLocation(Location location);

       bool CheckIfManagerExists(string email, string password );
    }
}