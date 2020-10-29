using System;
using StoreAppUI.Menus;

namespace StoreAppUI.Menus
{
    public class ManagerLoginMenu :IMenu
    {
        public void Start(){

            string username="";
            string password="";

            string usernametemp="manager";        // for now until sql db connected
            string passwordtemp="password";

            Console.WriteLine("  \nManager Login Menu");
            Console.WriteLine("--------------------");

            Console.Write("Enter Username: ");
            username = Console.ReadLine();
            Console.Write("Enter Password: ");
            password = Console.ReadLine();

            if (username==usernametemp && password==passwordtemp) { // TODO Check if user db logic and busniness public bool aManager bl  

                ManagerMainMenu managerMainMenu = new ManagerMainMenu();
                managerMainMenu.Start();
            }
            else {

                Console.WriteLine("**Wrong Credentials**");

                ManagerLoginMenu managerLoginMenu = new ManagerLoginMenu();
                managerLoginMenu.Start();
            }

        }
    }
}