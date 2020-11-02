using System.Data.SqlTypes;
using StoreAppDB.Models;
using StoreAppDB.Interfaces;
using StoreAppDB;
namespace StoreAppLib
{
    public class LocationActions
    {
        private StoreAppContext context;
        private ILocationRepoActions locationRepo;

        public LocationActions(StoreAppContext context, ILocationRepoActions locationRepo)
        {
            this.context = context;
            this.locationRepo = locationRepo;
        }

        public Location GetLocationById(int locationId) {

            return locationRepo.GetLocationById(locationId);
        }
    }
}