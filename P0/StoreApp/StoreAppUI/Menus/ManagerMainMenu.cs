using System;
using StoreAppDB.Models;
using StoreAppLib;
using StoreAppDB;
using StoreAppDB.Interfaces;

namespace StoreAppUI.Menus
{
    public class ManagerMainMenu :IMenu
    {
        private StoreAppContext context;

        private IManagerRepoActions managerRepoActions;
        private ILocationRepoActions locationRepoActions;

        private ManagerActions managerActions;

        private Location location;
        public ManagerMainMenu(StoreAppContext context, IManagerRepoActions managerRepoActions, ILocationRepoActions locationRepoActions ,Location location)
        {
            this.context = context;
            this.managerRepoActions = managerRepoActions;

            this.managerActions = new ManagerActions(context,managerRepoActions);

            this.location = location;
        }

        
        public void Start(){
            string option = "";

            Console.WriteLine("---------------------");
            Console.WriteLine("  MANAGER MAIN MENU");
            Console.WriteLine("---------------------");

            Console.WriteLine($"[0]View {location.LocationName} Order History \n[1]Replenish {location.LocationName} Inventory");
            option = Console.ReadLine();

            switch (option) {

                case "0":

                    break;
                case "1":
                    // //get new list set it equal to getbaseballBatsbylocation() 

                    // // for each product in products print out contents.

                    // BaseballBat newBat = new BaseballBat();

                    // Console.Write("Enter name of bat: ");
                    // newBat.ProductName = Console.ReadLine();

                    // Console.Write("Enter type of bat(Metal or Wood): ");
                    // newBat.ProductType = Console.ReadLine();

                    // Console.Write("Enter price of bat: ");
                    // newBat.ProductPrice = float.Parse(Console.ReadLine());

                    // //ask for how many want to add

                    // managerActions.AddBaseballBat(newBat);

                    // //updateinventory(newbat.id, quantity, locationId ); 


                    /* print list of products at this location 

                        Enter pruduct id 
                        Enter Quantity
                            updaTE quantity on yhat product
                                print list agfin with updateed quanity 
                    */


                    break;
                default:
                    Console.WriteLine("Wrong option!");
                    break;


            }


        }
    }
}