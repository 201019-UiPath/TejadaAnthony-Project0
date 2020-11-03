using StoreAppDB.Models;
using System.Collections.Generic;


namespace StoreAppDB.Interfaces
{
    public interface IInventoryRepoActions
    {
        void UpdateInventoryQuantity(Inventory inventory);
        List<Inventory> GetInventoryByLocationId(int id);

        Inventory GetInventoryRecordByInventoryNumber(int id);
    }
}