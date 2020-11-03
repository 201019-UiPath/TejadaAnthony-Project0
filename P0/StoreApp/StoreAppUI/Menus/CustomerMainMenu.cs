using System.Collections.Generic;
using StoreAppLib;
using StoreAppDB;
using StoreAppDB.Interfaces;
using System;
using StoreAppDB.Models;
namespace StoreAppUI.Menus
{
    public class CustomerMainMenu : IMenu
    {
        Location currLocation;
        Customer signedInCustomer;
        StoreAppContext context;

        CustomerActions customerActions;
        LocationActions locationActions;
        InventoryActions inventoryActions;
        OrderActions orderActions;

        ICustomerRepoActions customerRepoActions;
        ILocationRepoActions locationRepoActions;
        IOrderRepoActions orderRepoActions;
        IInventoryRepoActions inventoryRepoActions;
        public CustomerMainMenu(StoreAppContext context, ICustomerRepoActions customerRepoActions,  ILocationRepoActions locationRepoActions, IOrderRepoActions orderRepoActions, IInventoryRepoActions inventoryRepoActions, Customer signedInCustomer, Location location)
        {
            this.context = context;

            this.customerActions = new CustomerActions(context, customerRepoActions);
            this.locationActions = new LocationActions(context, locationRepoActions);
            this.inventoryActions = new InventoryActions(context, inventoryRepoActions);
            this.orderActions = new OrderActions(context,orderRepoActions);

            this.customerRepoActions = customerRepoActions;
            this.locationRepoActions = locationRepoActions;
            this.orderRepoActions = orderRepoActions;
            this.inventoryRepoActions = inventoryRepoActions;

            this.currLocation = location;
            this.signedInCustomer = signedInCustomer;

        }

        public void Start(){

            string option = "";

            Console.WriteLine("------------------------");
            Console.WriteLine("  CUSTOMER MAIN MENU");
            Console.WriteLine("------------------------");
            Console.WriteLine($"USER: {signedInCustomer.Name} at {currLocation.LocationName}");

            Console.WriteLine("[0]View Inventory/Place Order [1]View Order History");
            option = Console.ReadLine();

            switch (option) 
            { 
                case "0":
                    string placeOrder="";
                    do {   
                        List<Inventory> currInventory = new List<Inventory>();

                        currInventory = inventoryActions.GetInventoryByLocationId(currLocation.LocationId);
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("InventoryId  | BatID | Quantity ");
                        Console.WriteLine("------------------------------------");
                        foreach (Inventory Inventory in currInventory)
                        {
                            Console.WriteLine($"     {Inventory.InventoryId}       |   {Inventory.BaseballBatsId}    |    {Inventory.Quantity}");
                        }

                        Orders newOrder = new Orders();
                        Inventory inventory = new Inventory();
                        DateTime nowTime = new DateTime();

                        int invId;
                        int quantity;

                        Console.WriteLine(" Order by Entering The InventoryId and Quantity Desired");

                        Console.Write("InventoryId: ");
                        invId = int.Parse(Console.ReadLine());
                        inventory=inventoryActions.GetInventoryById(invId);

                        Console.Write("Quantity: ");
                        quantity = int.Parse(Console.ReadLine());

                        newOrder.OrderDate = nowTime.ToString();
                        newOrder.LocationId = currLocation.LocationId;
                        newOrder.CustomerId = signedInCustomer.CustomerId;
                        
                        inventory.Quantity -= quantity;

                        inventoryActions.UpdateInventory(inventory);
                        orderActions.AddNewOrder(newOrder);

                        Console.Write("Order Placed! Buy More? (y/n):");
                        placeOrder = Console.ReadLine();

                    } while (placeOrder !="n");

                    break;

                case "1":
                 List<Orders> orders = new List<Orders>();
                    orders = orderActions.GetOrdersByCustomerId(signedInCustomer.CustomerId);

                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("        Order Date          | LoactionId | CustomerId ");
                    Console.WriteLine("-----------------------------------------------------");

                    foreach (Orders order in orders) { 
                        
                        Console.WriteLine($"     {order.OrderDate}       |   {order.LocationId}    |    {order.CustomerId}  ");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }


        }
    }
}