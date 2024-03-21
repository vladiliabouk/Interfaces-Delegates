using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class MenuItem
    {
        private string m_NameOfItem;
        public event Action m_Action;

        public MenuItem(string i_nameOfItem)
        {
            m_NameOfItem = i_nameOfItem;
        }

        public string NameOfItem
        {
            get { return m_NameOfItem; }
        }


        public void StartAll()
        {
            if (m_Action != null)
            {
                m_Action.Invoke();
            }
        }
    }
}
