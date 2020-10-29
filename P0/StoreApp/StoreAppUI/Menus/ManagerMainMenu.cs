using System;
namespace StoreAppUI.Menus
{
    public class ManagerMainMenu :IMenu
    {
        public void Start(){
            string option = "";

            Console.WriteLine("  \nManager Main Menu");
            Console.WriteLine("--------------------");

            Console.WriteLine("[0]Location Order History [1]Update Location Inventory");
            option = Console.ReadLine();

            switch (option) {

                case "0":
                    // TODO location view order history menu  db getOrderHistoryByLocaton(locationName) bl viewOrderHistory()
                    ///locationhistorymanu object initialize
                    //object.start
                    break;
                case "1":
                    //locationhistorymanu object initialize
                    //object.start
                    break;
                default:
                    Console.WriteLine("Wrong option!");
                    break;


            }


        }
    }
}