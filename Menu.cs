using System;
using System.Collections.Generic;
using System.Linq;

namespace menu
{
public class Menu
    {
        public Menu(IEnumerable<string> items)      // Itererar över elementet
        {
            Items = items.ToArray();                // Gör om till en array
        }
        public IReadOnlyList<string> Items {get;}
        public int SelectedIndex {get; private set;} = 0; // Utgångspunkt med inget markerat
        public string SelectedOption => SelectedIndex != - 1 ? Items[SelectedIndex] : null;
        public void MoveUp() => SelectedIndex = Math.Max(SelectedIndex - 1, 0);      // Rör dig ett steg uppåt om du inte är på högsta nivån
        public void MoveDown() => SelectedIndex = Math.Min(SelectedIndex + 1, Items.Count - 1); // Rör dig ett steg neråt om du inte är på lägsta nivån

        public Menu GetMenu(Menu menu, string header)
        {
            Console.CursorVisible = false;
            var menuPainter = new ConsoleMenuPainter(menu);        // Skapar meny med hjälp av klassen

            Console.Clear();                                        // Så att consolen alltid ser likadan ut

            Console.WriteLine(header);                              // Skriv ut header

            for (int i = 0; i <= header.Length; i++)
            {
                Console.Write('-');
            }

            bool done = false;

            while (!done)
            {
                menuPainter.Paint();                                // Skriver ut menyn
                var keyInfo = Console.ReadKey();                    // Läser av tangentnedtryckning

                switch (keyInfo.Key)
                {                                                    // Switch argument för de olika tangenterna
                    case ConsoleKey.UpArrow:
                        menu.MoveUp();
                        break;
                    case ConsoleKey.DownArrow:
                        menu.MoveDown();
                        break;
                    // Om enter har tryckts gå ur meny loopen
                    case ConsoleKey.Enter:
                        done = true;
                        break;
                }
            }
            Console.CursorVisible = true;
            return menu;
        }
        public Menu GetMenu(Menu menu, string header, string[] Content)
        {
            Console.CursorVisible = false;
            var menuPainter = new ConsoleMenuPainter(menu);        // Skapar meny med hjälp av klassen

            Console.Clear();                                        // Så att consolen alltid ser likadan ut

            Console.WriteLine(header);                              // Skriv ut header

            for (int i = 0; i <= header.Length; i++)
            {
                Console.Write('-');
            }

            bool done = false;

            while (!done)
            {
                menuPainter.Paint(Content);                                // Skriver ut menyn
                var keyInfo = Console.ReadKey();                    // Läser av tangentnedtryckning

                switch (keyInfo.Key)
                {                                                    // Switch argument för de olika tangenterna
                    case ConsoleKey.UpArrow:
                        menu.MoveUp();
                        break;
                    case ConsoleKey.DownArrow:
                        menu.MoveDown();
                        break;
                    // Om enter har tryckts gå ur meny loopen
                    case ConsoleKey.Enter:
                        done = true;
                        break;
                }
            }
            Console.CursorVisible = true;

            return menu;
        }
    }
    public class ConsoleMenuPainter
    {
        readonly Menu menu;
        public ConsoleMenuPainter(Menu menu)
        {
            this.menu = menu;
        }
        public void Paint()
        {
            for (int i = 0; i < menu.Items.Count; i++){

                var color = menu.SelectedIndex == i ? ConsoleColor.Yellow : ConsoleColor.Gray;
                Console.ForegroundColor = color;
                int offset = 2+i;
                Console.SetCursorPosition(0, offset);

                if (i == menu.SelectedIndex)
                {
                    Console.Write('>');            
                }
                else
                {
                    Console.Write(' ');
                }

                Console.SetCursorPosition(1, offset);
                Console.WriteLine (menu.Items[i]);
            }
        }
        public void Paint(string[] Content)
        {
            for (int i = 0; i < menu.Items.Count; i++){

                var color = menu.SelectedIndex == i ? ConsoleColor.Yellow : ConsoleColor.Gray;
                Console.ForegroundColor = color;
                int offset = 2 + i;
                Console.SetCursorPosition(0, offset);

                if (i == menu.SelectedIndex)
                {
                    Console.Write('>');            
                }
                else
                {
                    Console.Write(' ');
                }

                Console.SetCursorPosition(1, offset);
                if (i < Content.Count())
                {
                    Console.WriteLine ("{0}: {1}", menu.Items[i], Content[i]);
                }
                else
                {
                    Console.WriteLine ("{0}", menu.Items[i]);
                }
            }
        }
    }
}
    
 