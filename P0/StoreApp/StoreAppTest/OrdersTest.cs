using System;
using Xunit;
using StoreAppDB.Interfaces;
using StoreAppLib;
using StoreAppDB.Models;
using StoreAppDB;
using System.Linq;

namespace StoreAppTest
{
    public class OrdersTest
    {   
        [Fact]
        public void AddOrderToTableTest()
        {
            //Arrange
            using var context = new StoreAppContext();
            IOrderRepoActions orderRepo = new DBRepo(context);
            Orders testOrder = new Orders();

            testOrder.Id = 1;
            testOrder.OrderDate =  DateTime.Now.ToString();
            testOrder.LocationId = 2;
            testOrder.CustomerId = 2;
            testOrder.Cost = 5;

            //Act 
            orderRepo.AddOrderToTable(testOrder);

            //Assert
            Assert.NotNull(context.Orders.Single(o => o.Id == testOrder.Id));


        }

    }
}
