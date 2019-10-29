using System.Collections.Generic;
using System;
using System.Linq;


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
                delegate(Book bk)
                {
                    return bk.Title.ToLower() == SearchVariable.ToLower();
                }
                ));
        // Find Author
            tempList.AddRange(BookInventory.FindAll(
                delegate(Book bk)
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
            {// Check so it only contains digits otherwise jump over this bit
                
                tempList.AddRange(BookInventory.FindAll(
                    delegate(Book bk)
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

    }

    class Novel : Book
    {
        public override string ToString()
        {
            return "Denna roman är en av de bästsäljande i Sverige";

        }
        public Novel(string Title, string Author, int ReleaseYear) : base (Title, Author, ReleaseYear)
        {
            BookType = "roman";
        }
    }
    class Periodical : Book
    {
        public override string ToString()
        {
            return "Denna tidsskrift har sålts 2 gånger, någonsin!";
        }
        public Periodical(string Title, string Author, int ReleaseYear) : base (Title, Author, ReleaseYear)
        {
            BookType = "tidsskrift";
        }

    }
    class ShortStory : Book
    {
        public override string ToString()
        {
            return "Denna novellsamling har 59 645 st köpt men bara 2 har läst den";
        }

        public ShortStory(string Title, string Author, int ReleaseYear) : base (Title, Author, ReleaseYear)
        {
            BookType = "novellsamling";
        }
    }
}