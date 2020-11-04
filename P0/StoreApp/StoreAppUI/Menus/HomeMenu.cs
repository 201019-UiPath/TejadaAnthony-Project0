using System;
using StoreAppDB;
using StoreAppLib;
using StoreAppDB.Interfaces;
using Serilog;

namespace StoreAppUI.Menus
{
    public class HomeMenu : IMenu
    {

        private StoreAppContext context;

        private IManagerRepoActions managerRepo;
        private ICustomerRepoActions customerRepo;
        private ILocationRepoActions locationRepo;
        private IBaseballBatRepoActions baseballBatRepo;
        private IOrderRepoActions orderRepo;
        private IInventoryRepoActions inventoryRepo;
        public HomeMenu(StoreAppContext context,  IManagerRepoActions managerRepo, ICustomerRepoActions customerRepo, ILocationRepoActions locationRepo, IBaseballBatRepoActions baseballBatRepo, IOrderRepoActions orderRepo, IInventoryRepoActions inventoryRepo)
        {
            this.context = context;
            this.managerRepo = managerRepo;
            this.customerRepo = customerRepo;
            this.locationRepo = locationRepo;
            this.baseballBatRepo = baseballBatRepo;
            this.orderRepo = orderRepo;
            this.inventoryRepo = inventoryRepo;
        }

        public void Start(){

            string option="";

            Console.WriteLine("--------------------------");
            Console.WriteLine("  WELCOME TO BETTERBATS!");
            Console.WriteLine("--------------------------");
            do
            {
                Console.WriteLine("[0]Login [1]Signup [2]Exit ");
                option = Console.ReadLine();
            }
            while (option != "2" && option!= "1" && option!="0");

            switch(option){

                case "0":
                IMenu loginMenu = new LoginMenu(context, managerRepo, customerRepo, locationRepo, baseballBatRepo, orderRepo, inventoryRepo);
                loginMenu.Start();
                break;

                case "1":
                IMenu signupMenu = new SignupMenu(context, managerRepo, customerRepo, locationRepo, baseballBatRepo, orderRepo, inventoryRepo);
                signupMenu.Start();
                break;

                case "2":
                break;

                default:
                    Log.Warning("Invalid Option Chosen!");
                    Console.WriteLine("Not a Valid Option.");
                break;
                
            }
        

        }
    }
}