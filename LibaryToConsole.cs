using System;
using System.Collections.Generic;

namespace library
{
    static class LibraryToConsole
    {
        public static void SearchBook(string SearchVariable)
        {
            List<Book> SearchList = Library.SearchForBook(SearchVariable);
            Console.Clear();

            if (SearchList.Count == 0)
            {
                Console.WriteLine("Sorry!");
                Console.WriteLine("We couldn't find the book you were searching for.");
            }

            PrintListContent(SearchList);
            Console.ReadKey();
        }

        public static void PrintBookInventory()
        {
            Console.Clear();
            PrintListContent(Library.GetBookInventory());
            Console.ReadKey();
        }

        private static void PrintListContent(List<Book> List)
        {
            foreach (Book BookInInventory in List)
            {
                Console.WriteLine("Title: {0}" , BookInInventory.Title);
                Console.WriteLine("Author: {0}" , BookInInventory.Author);
                Console.WriteLine("Release year: {0}" , BookInInventory.ReleaseYear);
                Console.WriteLine(); 
            }
        }
    }
}