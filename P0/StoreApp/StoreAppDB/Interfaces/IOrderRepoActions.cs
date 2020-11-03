using StoreAppDB.Models;
using System.Collections.Generic;

namespace StoreAppDB.Interfaces
{
    public interface IOrderRepoActions
    {
        void AddOrderToTable(Orders order);

        List<Orders> GetOrdersByIdAndLocation(int id, int locationId);
    }
}