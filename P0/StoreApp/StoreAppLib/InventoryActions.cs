using System.Collections.Generic;
using System.Data.SqlTypes;
using StoreAppDB.Models;
using StoreAppDB.Interfaces;
using StoreAppDB;
namespace StoreAppLib
{
    public class InventoryActions
    {   
        private StoreAppContext context;
        private IInventoryRepoActions inventoryRepo;

        public InventoryActions(StoreAppContext context, IInventoryRepoActions inventoryRepo)
        {
            this.context = context;
            this.inventoryRepo = inventoryRepo;
        }

        public List<Inventory> GetInventoryByLocationId(int id) {

            return inventoryRepo.GetInventoryByLocationId(id);

        }


        public void UpdateInventory(Inventory inventory) { 
                inventoryRepo.UpdateInventoryQuantity(inventory);
        }

        public Inventory GetInventoryById(int id) {

            return inventoryRepo.GetInventoryRecordByInventoryNumber(id);

        }
    }
}