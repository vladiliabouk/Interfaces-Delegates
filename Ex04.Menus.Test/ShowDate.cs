using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowDate : IMenuFunctions
    {
        void IMenuFunctions.Run()
        {
            Run();
        }
        private static void Run()
        {
            Console.WriteLine("\nThe date is: " + DateTime.Now.ToString("MM / dd / yyyy"));
            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }
    }
}
