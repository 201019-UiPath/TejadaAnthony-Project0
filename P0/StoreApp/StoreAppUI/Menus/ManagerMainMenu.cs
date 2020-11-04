using System;
using StoreAppDB.Models;
using StoreAppLib;
using StoreAppDB;
using StoreAppDB.Interfaces;
using System.Collections.Generic;
using Serilog;

namespace StoreAppUI.Menus
{
    public class ManagerMainMenu :IMenu
    {
        private StoreAppContext context;

        private IManagerRepoActions managerRepoActions;
        private ILocationRepoActions locationRepoActions;
        private IInventoryRepoActions inventoryRepoActions;
        private IOrderRepoActions orderRepoActions;

        private ManagerActions managerActions;
        private InventoryActions inventoryActions;
        private OrderActions orderActions;

        private Location location;
        public ManagerMainMenu(StoreAppContext context, IManagerRepoActions managerRepoActions, ILocationRepoActions locationRepoActions, IInventoryRepoActions inventoryRepoActions, IOrderRepoActions orderRepoActions ,Location location)
        {
            this.context = context;
            this.managerRepoActions = managerRepoActions;
            this.inventoryRepoActions = inventoryRepoActions;
            this.orderRepoActions = orderRepoActions;

            this.managerActions = new ManagerActions(context,managerRepoActions);
            this.inventoryActions = new InventoryActions(context,inventoryRepoActions);
            this.orderActions = new OrderActions(context, orderRepoActions);

            this.location = location;
        }

        
        public void Start(){
            while (true)
            {
                string option = "";

                Console.WriteLine("---------------------");
                Console.WriteLine("  MANAGER MAIN MENU");
                Console.WriteLine("---------------------");

                Console.WriteLine($"[0]View {location.LocationName} Order History \n[1]Replenish {location.LocationName} Inventory");
                option = Console.ReadLine();

                switch (option)
                {

                    case "0":
                        List<Orders> orders = new List<Orders>();
                        orders = orderActions.GetOrdersByLocationId(location.LocationId);

                        Console.WriteLine("-----------------------------------------------------");
                        Console.WriteLine("        Order Date          | LoactionId | CustomerId ");
                        Console.WriteLine("-----------------------------------------------------");

                        foreach (Orders order in orders)
                        {

                            Console.WriteLine($"     {order.OrderDate}       |   {order.LocationId}    |    {order.CustomerId}  ");
                        }

                        break;
                    case "1":

                        string done = "";
                        do
                        {
                            List<Inventory> currInventory = new List<Inventory>();

                            currInventory = inventoryActions.GetInventoryByLocationId(location.LocationId);
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine("InventoryId  | BatID | Quantity ");
                            Console.WriteLine("------------------------------------");
                            foreach (Inventory Inventory in currInventory)
                            {
                                Console.WriteLine($"     {Inventory.InventoryId}       |   {Inventory.BaseballBatsId}    |    {Inventory.Quantity}");
                            }

                            Inventory inventory = new Inventory();
                            int id;
                            int replenish;

                            Console.WriteLine("-------------------------------");
                            Console.WriteLine("  UPDATE INVENTORY");
                            Console.WriteLine("-------------------------------");

                            Console.Write("Inventory ID: ");
                            id = int.Parse(Console.ReadLine());

                            inventory = inventoryActions.GetInventoryById(id);

                            Console.Write("Amount to Replenish?: ");
                            replenish = int.Parse(Console.ReadLine());

                            inventory.Quantity += replenish;

                            inventoryActions.UpdateInventory(inventory);
                            Log.Information("Inventory Updated By Manger");

                            Console.Write("Updated Inventory! Continue? (y/n):");
                            done = Console.ReadLine();

                        } while (done != "n");


                        break;
                    default:
                        Console.WriteLine("Wrong option!");
                        break;


                }
            }

        }
    }
}