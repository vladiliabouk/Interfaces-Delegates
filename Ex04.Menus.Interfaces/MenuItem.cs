using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{

    public class MenuItem
    {
        private string m_NameOfItem;
        private readonly List<IMenuFunctions> r_FunctionsList = new List<IMenuFunctions>();

        public MenuItem(string i_nameOfItem)
        {
            m_NameOfItem = i_nameOfItem;
        }

        public string NameOfItem
        {
            get { return m_NameOfItem; }
        }

        public void AddNewFunction(IMenuFunctions i_newFunction)
        {
            r_FunctionsList.Add(i_newFunction);
        }

        public void StartAll()
        {
            foreach (IMenuFunctions functionToStart in r_FunctionsList)
            {
                functionToStart.Run();
            }
        }
    }
}
