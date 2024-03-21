using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{

    class DelegateMenu
    {
        private readonly MainMenu r_MainMenu = new MainMenu("Delegates Main Menu", true);
        private readonly MainMenu r_DateTimeMenu = new MainMenu("Show Date/Time", false);
        private readonly MainMenu r_VersionAndCapitalsMenu = new MainMenu("Version and Capitals", false);

        public DelegateMenu()
        {
            MenuItem i_DateTimeItem = new MenuItem("Show Date/Time");
            MenuItem i_VersionAndCapitalsItem = new MenuItem("Version and Capitals");
            MenuItem i_DateItem = new MenuItem("Show Date");
            MenuItem i_TimeItem = new MenuItem("Show Time");
            MenuItem i_VersionItem = new MenuItem("Show Version");
            MenuItem i_CapitalsItem = new MenuItem("Count Capitals");
            i_DateItem.m_Action += ShowDate;
            i_TimeItem.m_Action += ShowTime;
            i_VersionItem.m_Action += ShowVersion;
            i_CapitalsItem.m_Action += CountCapitals;
            i_DateTimeItem.m_Action += r_DateTimeMenu.Show;
            i_VersionAndCapitalsItem.m_Action += r_VersionAndCapitalsMenu.Show;
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

        public void ShowDate()
        {
        
            Console.WriteLine("\nThe date is: " + DateTime.Now.ToString("MM/dd/yyyy"));
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public void ShowTime()
        {
            Console.WriteLine("\nThe Hour is: " + DateTime.Now.ToString("HH:mm:ss"));
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public void ShowVersion()
        {
            Console.WriteLine("\nVersion: 24.1.4.9633");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public void CountCapitals()
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
