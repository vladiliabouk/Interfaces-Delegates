using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Test
{
    class Program
    {
        public static void Main()
        {
            DelegateMenu m_DelegateMenu = new DelegateMenu();
            InterfaceMenu m_InterfaceMenu = new InterfaceMenu();

            m_InterfaceMenu.Run();
            Console.Clear();
            m_DelegateMenu.Run();

        }
    }
}
