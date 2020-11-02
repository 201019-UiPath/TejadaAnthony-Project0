using StoreAppDB.Models;
using System.Collections.Generic;


namespace StoreAppDB.Interfaces
{
    public interface IInventoryRepoActions
    {
        void UpdateInventoryQuantity(int batId, int quantity, int locationId);//change to object 
    }
}