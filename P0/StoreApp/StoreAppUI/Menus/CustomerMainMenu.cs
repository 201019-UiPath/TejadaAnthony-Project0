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

                    List<Inventory> currInventory = new List<Inventory>();

                    currInventory = inventoryActions.GetInventoryByLocationId(currLocation.LocationId);
                    Console.WriteLine("----------------");
                    Console.WriteLine("BatID | Quantity ");
                    Console.WriteLine("----------------");
                    foreach (Inventory Inventory in currInventory)
                    {

                        Console.WriteLine($"{Inventory.BaseballBatsId}     |     {Inventory.Quantity}");
                    }
                    

                    break;

                case "1":
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }


        }
    }
}