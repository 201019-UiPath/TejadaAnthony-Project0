// using System;
// namespace StoreAppUI.Menus
// {
//     public class CustomerOrManagerMenu:IMenu
//     {
//         public void Start(){
//             string option="";  
//             Console.Write("Are you a [0]Customer or [1]Manager? ");
//             option = Console.ReadLine();

//             switch(option){

//                 case "0":
//                 IMenu loginMenu = new LoginMenu();
//                 loginMenu.Start();
//                 break;

//                 case "1":
//                 IMenu managerLoginMenu = new ManagerLoginMenu();
//                 managerLoginMenu.Start();
//                 break;

//                 default:
//                 Console.WriteLine("Not a valid option!");
//                 break;
//             }

//         }        
//     }
// }