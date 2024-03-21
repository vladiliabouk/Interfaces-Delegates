using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowVersion : IMenuFunctions
    {
        void IMenuFunctions.Run()
        {
            Run();
        }
        private static void Run()
        {
            Console.WriteLine("\nVersion: 24.1.4.9633");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
