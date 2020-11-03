using System;
using StoreAppUI.Menus;
using StoreAppDB;
using Serilog;

namespace StoreAppUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
            .WriteTo.File("log.txt",  outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
            .CreateLogger();

            Log.Information("Program Started");

            StoreAppContext context = new StoreAppContext();
            IMenu homeMenu = new HomeMenu(context, new DBRepo(context), new DBRepo(context), new DBRepo(context), new DBRepo(context), new DBRepo(context), new DBRepo(context));
            homeMenu.Start();

                                                // IManagerRepoActions  ICustomerRepoActions ILocationRepoActions IBaseballBatRepoActions IOrderRepoActions    IInventoryRepoActions
        }
    }
}
