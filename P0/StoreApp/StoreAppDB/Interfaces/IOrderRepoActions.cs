using StoreAppDB.Models;
using System.Collections.Generic;

namespace StoreAppDB.Interfaces
{
    public interface IOrderRepoActions
    {
        void AddOrderToTable(Orders order);

        List<Orders> GetOrdersByLocationId(int locationId);
        List<Orders> GetOrdersByCustomerId(int cusId);
    }
}