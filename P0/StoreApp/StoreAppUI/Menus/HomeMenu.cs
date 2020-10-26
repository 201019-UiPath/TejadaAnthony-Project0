using System;
namespace StoreAppUI.Menus
{
    public class HomeMenu : IMenu
    {
     public void Start(){
        string option="";

        do{

            Console.WriteLine("\nWelcome to BetterBats!");
            Console.WriteLine("[0]Login\n[1]Signup\n[2]Exit ");
                
            option = Console.ReadLine();

            switch(option){
                case "0":
                IMenu customerOrManagerMenu = new CustomerOrManagerMenu();
                customerOrManagerMenu.Start();
                break;
                case "1":
                IMenu signupMenu = new SignupMenu();
                signupMenu.Start();
                break;
                default:
                    Console.WriteLine("Not a Valid Option.");
                break;
                
            }

        }while(option != "2");
        

        }
    }
}