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
        ManagerActions managerActions;
        IManagerRepoActions managerRepoActions;
        public LoginMenu(StoreAppContext context, IManagerRepoActions managerRepoActions) {

            this.context = context;
            this.managerRepoActions=managerRepoActions;

            this.managerActions = new ManagerActions(context, managerRepoActions);

        }
        public void Start(){

            string email="";
            string passWord="";
            Console.WriteLine("\nPlease Enter Credentials.");

            Console.Write("Email: ");
            email = Console.ReadLine();

            Console.Write("Password: ");
            passWord = Console.ReadLine();


            if (managerActions.ManagerExists(email,passWord) == true) {

                IMenu managerMainMenu = new ManagerMainMenu(context, managerRepoActions);
                managerMainMenu.Start();
            }
            else {
                Console.WriteLine("NOPE!");
            }



        }
    }
}