using StoreAppDB.Models;
using System.Collections.Generic;

namespace StoreAppDB.Interfaces
{
    public interface IManagerRepoActions
    {
        void AddBaseballBatIntoTableAsync(BaseballBat baseballbat);

       bool CheckIfManagerExists(string email, string password );
    }
}