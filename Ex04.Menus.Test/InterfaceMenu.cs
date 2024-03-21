using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    class InterfaceMenu
    {
        private readonly MainMenu r_MainMenu = new MainMenu("Interface Main Menu", true);
        private readonly MainMenu r_DateTimeMenu = new MainMenu("Show Date/Time", false);
        private readonly MainMenu r_VersionAndCapitalsMenu = new MainMenu("Version and Capitals", false);

        public InterfaceMenu()
        {
            MenuItem i_DateTimeItem = new MenuItem("Show Date/Time");
            MenuItem i_VersionAndCapitalsItem = new MenuItem("Version and Capitals");
            MenuItem i_DateItem = new MenuItem("Show Date");
            MenuItem i_TimeItem = new MenuItem("Show Time");
            MenuItem i_VersionItem = new MenuItem("Show Version");
            MenuItem i_CapitalsItem = new MenuItem("Show Capitals");
            i_DateItem.AddNewFunction(new ShowDate());
            i_TimeItem.AddNewFunction(new ShowTime());
            i_VersionItem.AddNewFunction(new ShowVersion());
            i_CapitalsItem.AddNewFunction(new CountCapitals());
            i_DateTimeItem.AddNewFunction(new Interfaces.Menus(r_DateTimeMenu));
            i_VersionAndCapitalsItem.AddNewFunction(new Interfaces.Menus(r_VersionAndCapitalsMenu));
            r_DateTimeMenu.AddNewItem(i_DateItem);
            r_DateTimeMenu.AddNewItem(i_TimeItem);
            r_VersionAndCapitalsMenu.AddNewItem(i_VersionItem);
            r_VersionAndCapitalsMenu.AddNewItem(i_CapitalsItem);
            r_MainMenu.AddNewItem(i_DateTimeItem);
            r_MainMenu.AddNewItem(i_VersionAndCapitalsItem);
        }

        public void Run()
        {
            r_MainMenu.Show();
        }
    }
}
