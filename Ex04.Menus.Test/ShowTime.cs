using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowTime : IMenuFunctions
    {
        void IMenuFunctions.Run()
        {
            Run();
        }
        private static void Run()
        {
            Console.WriteLine("The Hour is: " + DateTime.Now.ToString("HH:mm:ss"));
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
