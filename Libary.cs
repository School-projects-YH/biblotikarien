using System;
using System.Linq;
using System.Collections.Generic;


namespace library
{
    class Library
    {
        private static List<Book> BookInventory = new List<Book>();
        // The main inventory for the whole libary

        /* ----------------------------- Public Methods ----------------------------- */

        public static List<Book> GetBookInventory()
        {// Method that returns the bookinventory
            return BookInventory;
        }
        public static void AddBook(Book Book)
        {// Add a single predefined book
            BookInventory.Add(Book);
        }
        public static void AddBook(List<Book> AddBookList)
        {// Add multiple books with a list
            BookInventory.AddRange(AddBookList);
        }
        public static void AddBook(string Title, string Author, int ReleaseYear)
        {// Allows for construction when adding a book
            Book book = new Book(Title, Author, ReleaseYear);
            BookInventory.Add(book);
        }

        public static List<Book> SearchForBook(string SearchVariable)
        {// Searches the list by adding the matching books in a new list which it returns
            List<Book> BookInventory = GetBookInventory();
            List<Book> tempList = new List<Book>();

            // Find title
            tempList.AddRange(BookInventory.FindAll(
                delegate (Book bk) // Delegate to easily search for matching properties
                {
                    return bk.Title.ToLower() == SearchVariable.ToLower();
                }
                ));
            // Find Author
            tempList.AddRange(BookInventory.FindAll(
                delegate (Book bk)
                {
                    if (tempList.Contains(bk))
                    {
                        return false;
                    }
                    return bk.Author.ToLower() == SearchVariable.ToLower();
                }
                ));

            // Find ReleaseYear
            if (IsDigitsOnly(SearchVariable))
            {// Check if the SearchVariable only contains digits

                tempList.AddRange(BookInventory.FindAll(
                    delegate (Book bk)
                    {
                        if (tempList.Contains(bk))
                        {
                            return false;
                        }
                        return bk.ReleaseYear == Convert.ToInt32(SearchVariable);
                    }
                    ));
            }
            return tempList;
        }

        /* ----------------------------- Private Methods ---------------------------- */

        private static bool IsDigitsOnly(string str)
        {// Check if the string only contains digits
            return str.All(Char.IsDigit);
        }
    }

    class Book : Library
    {
        internal string Title;
        internal string Author;
        internal int ReleaseYear;
        internal string BookType;
        public Book(string Title, string Author, int ReleaseYear)
        {
            this.Title = Title;
            this.Author = Author;
            this.ReleaseYear = ReleaseYear;
        }

        public override string ToString()
        {
            return "Ordinary book";
        }
    }

    class Novel : Book
    {
        public override string ToString()
        {
            return "Did you know that the first novel written is Robinson Crusoe?";

        }
        public Novel(string Title, string Author, int ReleaseYear) : base(Title, Author, ReleaseYear)
        {
            BookType = "Novel";
        }
    }
    class Periodical : Book
    {
        public override string ToString()
        {
            return "Periodeicals started emerging in the 17th century";
        }
        public Periodical(string Title, string Author, int ReleaseYear) : base(Title, Author, ReleaseYear)
        {
            BookType = "Periodical";
        }
    }
    class ShortStory : Book
    {
        public override string ToString()
        {
            return "Short stories have a word count between 1 000 to 4 000 words";
        }
        public ShortStory(string Title, string Author, int ReleaseYear) : base(Title, Author, ReleaseYear)
        {
            BookType = "Short story";
        }
    }
    class Biography : Book
    {
        public override string ToString()
        {
            return "The first biography was about Samuel Johnson and was published in 1791";
        }
        public Biography(string Title, string Author, int ReleaseYear) : base(Title, Author, ReleaseYear)
        {
            BookType = "Biography";
        }
    }

}