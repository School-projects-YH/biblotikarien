using System;
using menu;
using library;
using System.Collections.Generic;

namespace biblotikarien
{
    class Program
    {
        static void Main(string[] args)
        {
            string header = "Välj ett av följande alternativ:";
            string[] menuContent = new string[] {"Lägg till böcker", "Sök efter en bok", "Inventarie"};

            Menu menu = new Menu(menuContent);

            menu = menu.GetMenu(menu, header);

            Book book = new Book("Fången", "Jk", 2006);
            Library.AddBook("Fången", "Jk", 2006);
            Library.AddBook("Fången", "Jk", 2006);
            Library.AddBook("Fången", "Jk", 2006);


            switch (menu.SelectedIndex)
            {
                case 0:
                // Lägg till böcker

                break;

                case 1:
                // Sök efter en bok
                

                

                break;

                case 2:
                // Inventarie
                
                break;    
            }
            
        }
    }
}
