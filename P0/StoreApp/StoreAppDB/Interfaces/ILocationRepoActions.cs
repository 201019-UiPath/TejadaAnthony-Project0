using StoreAppDB.Models;
using System.Collections.Generic;
namespace StoreAppDB.Interfaces
{
    public interface ILocationRepoActions
    {

        List<Location> GetAllLocations();
        Location GetLocationById(int locationId);
    }
}