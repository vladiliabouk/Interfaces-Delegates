using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CountCapitals : IMenuFunctions
    {
        public void Run()
        {
            string i_InputSentence;
            int i_OutputCount = 0;

            Console.WriteLine("Please enter your sentence:");
            i_InputSentence = Console.ReadLine();
            foreach (char c in i_InputSentence)
            {
                if (char.IsLetter(c) && char.IsUpper(c))
                {
                    i_OutputCount++;
                }
            }
            Console.WriteLine("\nThere are {0} Capitals in your sentence.", i_OutputCount);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
