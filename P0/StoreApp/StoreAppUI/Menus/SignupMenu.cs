using System;
using StoreAppDB;
using StoreAppLib;
using StoreAppDB.Interfaces;
using StoreAppDB.Models;

namespace StoreAppUI.Menus
{
    public class SignupMenu: IMenu
    {
        StoreAppContext context;
        CustomerActions customerActions;
        ICustomerRepoActions customerRepoActions;
        public SignupMenu(StoreAppContext context, ICustomerRepoActions customerRepoActions) {

            this.context = context;
            this.customerRepoActions=customerRepoActions;

            this.customerActions = new CustomerActions(context, customerRepoActions);

        }
        public void Start(){

            Customer newCustomer = new Customer();

            Console.WriteLine("--------------");
            Console.WriteLine("   SIGNUP");
            Console.WriteLine("--------------");

            Console.Write("Name: ");
            newCustomer.Name=Console.ReadLine();

            Console.Write("Email: ");
            newCustomer.Email=Console.ReadLine();

            Console.Write("Password: ");
            newCustomer.Password=Console.ReadLine();


            if (!customerActions.CustomerExists(newCustomer.Email, newCustomer.Password)) {
                customerActions.AddCustomer(newCustomer); 
                }
            else {
                Console.WriteLine("User Already Exists..");
            }

        }
    }
}