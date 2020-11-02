using StoreAppDB.Models;
using System.Collections.Generic;
namespace StoreAppDB.Interfaces
{
    public interface IBaseballBatRepoActions
    {
        List<BaseballBat> GetBaseballBatsByLocation(int id);
    }
}