using System;
using StoreAppDB;
using StoreAppLib;
using StoreAppDB.Interfaces;
using StoreAppDB.Models;

namespace StoreAppUI.Menus
{
    public class SignupMenu: IMenu
    {
        StoreAppContext context;
        CustomerActions customerActions;

        private IManagerRepoActions managerRepoActions;
        private ICustomerRepoActions customerRepoActions;
        private ILocationRepoActions locationRepoActions;
        private IBaseballBatRepoActions baseballBatRepoActions;
        private IOrderRepoActions orderRepoActions;
        private IInventoryRepoActions inventoryRepoActions;
        public SignupMenu(StoreAppContext context, IManagerRepoActions managerRepoActions, ICustomerRepoActions customerRepoActions, ILocationRepoActions locationRepoActions, IBaseballBatRepoActions baseballBatRepoActions, IOrderRepoActions orderRepoActions, IInventoryRepoActions inventoryRepoActions) {

            this.context = context;

            this.customerRepoActions=customerRepoActions;
            this.managerRepoActions  = managerRepoActions;
            this.locationRepoActions = locationRepoActions;
            this.inventoryRepoActions = inventoryRepoActions;
            this.baseballBatRepoActions = baseballBatRepoActions;
            this.orderRepoActions = orderRepoActions;

            this.customerActions = new CustomerActions(context, customerRepoActions);

        }
        public void Start(){

            Customer newCustomer = new Customer();

            Console.WriteLine("--------------");
            Console.WriteLine("   SIGNUP");
            Console.WriteLine("--------------");

            Console.Write("Name: ");
            newCustomer.Name=Console.ReadLine();

            Console.Write("Email: ");
            newCustomer.Email=Console.ReadLine();

            Console.Write("Password: ");
            newCustomer.Password=Console.ReadLine();


            if (!customerActions.CustomerExists(newCustomer.Email, newCustomer.Password)) {
                customerActions.AddCustomer(newCustomer); 

                IMenu loginMenu = new LoginMenu(context, managerRepoActions, customerRepoActions, locationRepoActions, baseballBatRepoActions, orderRepoActions, inventoryRepoActions);
                loginMenu.Start();

                }
            else {
                Console.WriteLine("User Already Exists..");
            }

        }
    }
}