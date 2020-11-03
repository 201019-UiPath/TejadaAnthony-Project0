using StoreAppDB.Models;
using StoreAppDB.Interfaces;
using StoreAppDB;
using System.Collections.Generic;

namespace StoreAppLib
{
    public class OrderActions
    {
        
        private StoreAppContext context;
        private IOrderRepoActions orderRepo;

        public OrderActions(StoreAppContext context, IOrderRepoActions orderRepo)
        {
            this.context = context;
            this.orderRepo = orderRepo;
        }

        public void AddNewOrder(Orders order) {

            orderRepo.AddOrderToTable(order);

        }

        public List<Orders> GetOrdersByLocationId(int locationId)
        {
           return orderRepo.GetOrdersByLocationId(locationId);
        }

        public List<Orders> GetOrdersByCustomerId(int cusId)
        {
            return orderRepo.GetOrdersByCustomerId(cusId);
        }

    }
}