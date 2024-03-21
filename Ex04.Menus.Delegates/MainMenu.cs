using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        private string m_NameOfMenu;
        private readonly List<MenuItem> r_ItemMenuList = new List<MenuItem>();
        private readonly bool r_IsMainMenu;

        public MainMenu(string i_nameOfMenu, bool i_isMainMenu)
        {
            m_NameOfMenu = i_nameOfMenu;
            r_IsMainMenu = i_isMainMenu;
            AddFirstItem();
        }

        private void AddFirstItem()
        {
            if (r_IsMainMenu)
            {
                MenuItem i_firstItem = new MenuItem("EXIT");
                r_ItemMenuList.Add(i_firstItem);
            }
            else
            {
                MenuItem i_firstItem = new MenuItem("BACK");
                r_ItemMenuList.Add(i_firstItem);
            }
        }

        public void AddNewItem(MenuItem i_newItem)
        {
            r_ItemMenuList.Add(i_newItem);
        }

        public void PrintMenu()
        {
            int counter = 0;
            Console.WriteLine("**{0}**", this.m_NameOfMenu);
            Console.WriteLine("-------------------------");
            foreach (MenuItem item in r_ItemMenuList)
            {
                Console.WriteLine("{0} -> {1}", counter, item.NameOfItem);
                counter++;
            }
            Console.WriteLine("-------------------------");
        }

        private bool isValidInput(string i_userInputStr, ref int i_userInputInt)
        {
            bool i_isValidInput = true;

            if (int.TryParse(i_userInputStr, out i_userInputInt))
            {
                if (i_userInputInt < 0 || i_userInputInt >= r_ItemMenuList.Count())
                {
                    Console.WriteLine("Error - The number worng.");
                    i_isValidInput = false;
                }
            }
            else
            {
                Console.WriteLine("Error - This is not number.");
                i_isValidInput = false;
            }

            return i_isValidInput;
        }

        public void Show()
        {
            string i_InputFromUser;
            int i_InputNum = 0;
            bool i_Wait = true;

            while (i_Wait)
            {
                PrintMenu();
                Console.WriteLine("Enter your request: 1 to 2 or press '0' to exit");
                i_InputFromUser = Console.ReadLine();
                if (isValidInput(i_InputFromUser, ref i_InputNum))
                {
                    if (i_InputNum != 0)
                    {
                        r_ItemMenuList[i_InputNum].StartAll();
                    }
                    else
                    {
                        i_Wait = false;
                    }
                }
                else
                {
                    Console.WriteLine("Press any key");
                    Console.ReadKey();
                }
            }
        }
    }
}
