using System;
using StoreAppDB;
using StoreAppLib;
using StoreAppDB.Interfaces;
using StoreAppDB.Models;

namespace StoreAppUI.Menus
{   
    public class LoginMenu : IMenu
    {
        StoreAppContext context;
        //library
        ManagerActions managerActions;
        CustomerActions customerActions;

        //database
        IManagerRepoActions managerRepoActions;
        ICustomerRepoActions customerRepoActions;

        public LoginMenu(StoreAppContext context, IManagerRepoActions managerRepoActions, ICustomerRepoActions customerRepoActions) {

            this.context = context;
            this.managerRepoActions=managerRepoActions;
            this.customerRepoActions = customerRepoActions;

            this.managerActions = new ManagerActions(context, managerRepoActions);
            this.customerActions = new CustomerActions(context, customerRepoActions);

        }
        public void Start(){

            string email="";
            string passWord="";
            Console.WriteLine("\nPlease Enter Credentials.");

            Console.Write("Email: ");
            email = Console.ReadLine();

            Console.Write("Password: ");
            passWord = Console.ReadLine();


            if (managerActions.ManagerExists(email,passWord)) {

                IMenu managerMainMenu = new ManagerMainMenu(context, managerRepoActions);
                managerMainMenu.Start();
            }
            else if(customerActions.CustomerExists(email,passWord)){
                IMenu customerMainMenu = new CustomerMainMenu(context, customerRepoActions);
                customerMainMenu.Start();
            }
            else {
                Console.WriteLine("User not found");
            }



        }
    }
}