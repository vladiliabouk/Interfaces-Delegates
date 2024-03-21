using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class Menus : IMenuFunctions
    {
        private MainMenu i_Menu;

        public Menus(MainMenu i_newmenu)
        {
            this.i_Menu = i_newmenu;
        }
        public void Run()
        {
            this.i_Menu.Show();
        }
    }
}
