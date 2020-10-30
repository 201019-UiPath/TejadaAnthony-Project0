using StoreAppDB.Models;
using System.Collections.Generic;

namespace StoreAppDB.Interfaces
{
    public interface IManagerRepoActions
    {
        void AddBaseballBatIntoTable(BaseballBat baseballBat);
        List<BaseballBat> GetAllBaseballBats();
    }
}