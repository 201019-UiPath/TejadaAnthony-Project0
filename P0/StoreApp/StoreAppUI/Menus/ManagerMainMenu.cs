using System;
using StoreAppDB.Models;
using StoreAppLib;
using StoreAppDB;
using StoreAppDB.Interfaces;
namespace StoreAppUI.Menus
{
    public class ManagerMainMenu :IMenu
    {
        StoreAppContext context;

        IManagerRepoActions managerRepoActions;

        ManagerActions managerActions;
        public ManagerMainMenu(StoreAppContext context, IManagerRepoActions managerRepoActions)
        {
            this.context = context;
            this.managerRepoActions = managerRepoActions;

            this.managerActions = new ManagerActions(context,managerRepoActions);
        }

        
        public void Start(){
            string option = "";

            Console.WriteLine("  \nManager Main Menu");
            Console.WriteLine("--------------------");

            Console.WriteLine("[0]Location Order History [1]Update Location Inventory");
            option = Console.ReadLine();

            switch (option) {

                case "0":

                    break;
                case "1":
                    BaseballBat newBat = new BaseballBat();

                    Console.Write("Enter name of bat: ");
                    newBat.ProductName = Console.ReadLine();

                    Console.Write("Enter type of bat(Metal or Wood): ");
                    newBat.ProductType = Console.ReadLine();

                    Console.Write("Enter price of bat: ");
                    newBat.ProductType = Console.ReadLine();

                    managerActions.AddBaseballBat(newBat);

                    break;
                default:
                    Console.WriteLine("Wrong option!");
                    break;


            }


        }
    }
}