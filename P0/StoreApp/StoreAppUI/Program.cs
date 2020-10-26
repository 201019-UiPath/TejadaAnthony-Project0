using System;
using StoreAppLib;
using StoreAppUI.Menus;

namespace StoreAppUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenu homeMenu = new HomeMenu();

            homeMenu.Start();
        }
    }
}
