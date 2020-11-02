using System;
using StoreAppUI.Menus;
using StoreAppDB;

namespace StoreAppUI
{
    class Program
    {
        static void Main(string[] args)
        {
            StoreAppContext context = new StoreAppContext();
            IMenu homeMenu = new HomeMenu(context, new DBRepo(context), new DBRepo(context), new DBRepo(context), new DBRepo(context), new DBRepo(context), new DBRepo(context));
            homeMenu.Start();

                                                // IManagerRepoActions  ICustomerRepoActions ILocationRepoActions IBaseballBatRepoActions IOrderRepoActions    IInventoryRepoActions
        }
    }
}
