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

        ICustomerRepoActions customerRepoActions;
        ILocationRepoActions locationRepoActions;
        IOrderRepoActions orderRepoActions;
        public CustomerMainMenu(StoreAppContext context, ICustomerRepoActions customerRepoActions,  ILocationRepoActions locationRepoActions, IOrderRepoActions orderRepoActions, Customer signedInCustomer, Location location)
        {
            this.context = context;

            this.customerActions = new CustomerActions(context, customerRepoActions);
            this.locationActions = new LocationActions(context, locationRepoActions);

            this.customerRepoActions = customerRepoActions;
            this.locationRepoActions = locationRepoActions;

            this.currLocation = location;
            this.signedInCustomer = signedInCustomer;

        }

        public void Start(){
            Console.WriteLine("------------------------");
            Console.WriteLine("  CUSTOMER MAIN MENU");
            Console.WriteLine("------------------------");

        }
    }
}