using System;
using StoreAppDB;
using StoreAppLib;
using StoreAppDB.Interfaces;
using StoreAppDB.Models;

namespace StoreAppUI.Menus
{   
    public class LoginMenu : IMenu
    {
        private StoreAppContext context;
        //library
        private ManagerActions managerActions;
        private CustomerActions customerActions;
        private LocationActions  locationActions;

        //database
        private IManagerRepoActions managerRepoActions;
        private ICustomerRepoActions customerRepoActions;
        private ILocationRepoActions locationRepoActions;
        private IBaseballBatRepoActions baseballBatRepoActions;
        private IOrderRepoActions orderRepoActions;
        private IInventoryRepoActions inventoryRepoActions;

        public LoginMenu(StoreAppContext context, IManagerRepoActions managerRepoActions, ICustomerRepoActions customerRepoActions, ILocationRepoActions locationRepoActions, IBaseballBatRepoActions baseballBatRepoActions, IOrderRepoActions orderRepoActions, IInventoryRepoActions inventoryRepoActions) {

            this.context = context;

            this.managerRepoActions  = managerRepoActions;
            this.customerRepoActions = customerRepoActions;
            this.locationRepoActions = locationRepoActions;
            this.inventoryRepoActions = inventoryRepoActions;
            this.baseballBatRepoActions = baseballBatRepoActions;
            this.orderRepoActions = orderRepoActions;

            this.managerActions  = new ManagerActions(context, managerRepoActions);
            this.customerActions = new CustomerActions(context, customerRepoActions);
            this.locationActions = new LocationActions(context, locationRepoActions);

        }
        public void Start(){

            string email="";
            string passWord="";
            int location ;

            Console.WriteLine("---------------------");
            Console.WriteLine("       LOGIN");
            Console.WriteLine("---------------------");

            Console.Write("Email: ");
            email = Console.ReadLine();

            Console.Write("Password: ");
            passWord = Console.ReadLine();

            Console.Write("Select Location [1]BetterBatsOne [2]BetterBatsTwo: ");
            location=int.Parse(Console.ReadLine());

            Location choosenLocation = new Location();
            Customer signedInCustomer = new Customer();

            choosenLocation = locationActions.GetLocationById(location);
            signedInCustomer = customerActions.GetCustomerByEmail(email);

            if (managerActions.ManagerExists(email,passWord)) {

                IMenu managerMainMenu = new ManagerMainMenu(context, managerRepoActions, locationRepoActions, choosenLocation);
                managerMainMenu.Start();
            }
            else if(customerActions.CustomerExists(email,passWord)){
                IMenu customerMainMenu = new CustomerMainMenu(context, customerRepoActions, locationRepoActions, orderRepoActions, inventoryRepoActions, signedInCustomer, choosenLocation);
                customerMainMenu.Start();
            }
            else {
                Console.WriteLine("User not found");
            }



        }
    }
}