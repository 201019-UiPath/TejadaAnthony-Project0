using System;
namespace StoreAppUI.Menus
{
    public class LoginMenu : IMenu
    {
        public void Start(){

            string userName="";
            string passWord="";
            Console.WriteLine("\nPlease Enter Credentials.");

            Console.Write("Username: ");
            userName = Console.ReadLine();

            Console.Write("Password: ");
            passWord = Console.ReadLine();

            //check if user. if yes send to customermenu else print no user found

            Console.WriteLine(userName+" "+passWord);

        }
    }
}