using StoreAppDB.Models;
using System.Collections.Generic;


namespace StoreAppDB.Interfaces
{
    public interface IInventoryRepoActions
    {
        void UpdateInventoryQuantity(int batId, int quantity, int locationId);
        List<Inventory> GetInventoryByLocationId(int id);
    }
}