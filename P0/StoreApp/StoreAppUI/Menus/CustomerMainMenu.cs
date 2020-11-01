using StoreAppLib;
using StoreAppDB;
using StoreAppDB.Interfaces;
using System;
using StoreAppDB.Models;
namespace StoreAppUI.Menus
{
    public class CustomerMainMenu : IMenu
    {
        StoreAppContext context;

        CustomerActions customerActions;
        ICustomerRepoActions customerRepoActions;

        public CustomerMainMenu(StoreAppContext context, ICustomerRepoActions customerRepoActions )
        {
            this.context = context;
            this.customerRepoActions = customerRepoActions;

            this.customerActions = new CustomerActions(context, customerRepoActions);
        }

        public void Start(){

            Console.Write("Customer Main Menu!");

        }
    }
}