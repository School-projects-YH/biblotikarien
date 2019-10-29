using System;
using System.Collections.Generic;



namespace library
{
    static class LibToConsole
    {
        public static void SearchBook(string SearchVariable)
        {
            List<Book> SearchList = Library.SearchForBook(SearchVariable);
            
            foreach(Book MatchingBook in SearchList)
            {
                Console.WriteLine("Title: {0}" , MatchingBook.Title);

            }

        }
    }
}