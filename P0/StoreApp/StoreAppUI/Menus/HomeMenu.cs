using System;
using StoreAppDB;
using StoreAppLib;
using StoreAppDB.Interfaces;

namespace StoreAppUI.Menus
{
    public class HomeMenu : IMenu
    {

        private StoreAppContext context;
        private IManagerRepoActions managerRepo;
        public HomeMenu(StoreAppContext context,  IManagerRepoActions managerRepo)
        {
            this.context = context;
            this.managerRepo = managerRepo;
        }

        public void Start(){
        string option="";

        Console.WriteLine("\nWelcome to BetterBats!");
        Console.WriteLine("[0]Login\n[1]Signup\n[2]Exit ");
                
        option = Console.ReadLine();

        switch(option){

            case "0":
                    IMenu loginMenu = new LoginMenu(context, managerRepo);
                    loginMenu.Start();
                break;

                case "1":
                IMenu signupMenu = new SignupMenu();
                signupMenu.Start();
                break;

                case "2":
                break;

                default:
                    Console.WriteLine("Not a Valid Option.");
                break;
                
            }
        

        }
    }
}