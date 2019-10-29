using System;
using menu;
using library;
namespace biblotikarien
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5 random books added
            Library.AddBook("Room on the Broom", "Julia Donaldson", 2003);
            Library.AddBook("Permanent Record", "Edward Snowden", 2019);
            Library.AddBook("Guts", "Raina Telgemeier", 2019);
            Library.AddBook("Strange Planet", "Nathan W.Pyle", 2019);
            Library.AddBook("The Beautiful Ones", "Prince", 2019);
            // Will be added as Ordinary Book

            Book myBook = new Novel("Strange Planet", "Nathan W.Pyle", 2019);
            // Will be added as a Novel
            Library.AddBook(myBook);

            string header = "Choose one of the following options:";
            string[] menuContent = new string[] { "Add book", "Search for a book", "List the inventory" };

            Menu menu = new Menu(menuContent);

            while (true)
            {
                menu = menu.GetMenu(menu, header);
                Console.ResetColor();
                switch (menu.SelectedIndex)
                {
                    case 0:
                        // Lägg till böcker
                        AddBook();
                        break;

                    case 1:
                        // Sök efter en bok
                        Console.WriteLine();
                        Console.WriteLine("What do you want to search for? ");
                        try
                        {
                            string SearchVariable = Console.ReadLine();
                            LibraryToConsole.SearchBook(SearchVariable);
                        }
                        catch
                        {

                        }
                        break;

                    case 2:
                        // Inventarie
                        LibraryToConsole.PrintBookInventory();
                        break;
                }
            }
        }
        private static void AddBook()
        {
            string header = "Add book";
            string[] menuContent = new string[] { "Title", "Author", "Release year" };
            string[] bookContent = new string[] { "", "", "" };
            Menu menu = new Menu(menuContent);
            string Title = "";
            string Author = "";
            string ReleaseYearString;
            int ReleaseYear = 0;

            do
            {
                menu = menu.GetMenu(menu, header, bookContent); 
                // Changed the menu class a bit so it fits this implementation 
                switch (menu.SelectedIndex)
                {
                    case 0:
                        // Title
                        Console.SetCursorPosition(8, 3);
                        Title = Console.ReadLine();
                        bookContent[0] = Title;
                        break;

                    case 1:
                        // Author
                        Console.SetCursorPosition(9, 4);
                        Author = Console.ReadLine();
                        bookContent[1] = Author;
                        break;

                    case 2:
                        // ReleaseYear
                        Console.SetCursorPosition(15, 5);
                        ReleaseYearString = Console.ReadLine();
                        try
                        {
                            ReleaseYear = Convert.ToInt32(ReleaseYearString);
                            bookContent[2] = ReleaseYearString;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Please only enter numbers!");
                            Console.ReadKey();
                            bookContent[2] = "";
                        }
                        break;
                }
                Console.ResetColor();
            } while (!IsListFilled(bookContent));

            Book CreatedBook = new Book(Title, Author, ReleaseYear);
            Library.AddBook(CreatedBook);
        }

        private static bool IsListFilled(string[] List)
        {
            foreach (string mystring in List)
            {
                if (mystring == "")
                {
                    return false;
                }
            }
            return true;
        }
    }
}
