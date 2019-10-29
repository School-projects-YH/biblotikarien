using System.Collections.Generic;
using System;

namespace library
{
    delegate bool CustomDel(string s);
    class Library
    {
        private static List<Book> BookInventory = new List<Book>();
        public static List<Book> GetBookInventory()
        {
            return BookInventory;
        }     
        public static void AddBook(Book Book)
        {
           BookInventory.Add(Book);
        }
        public static void AddBook(List<Book> AddBookList)
        {
           BookInventory.AddRange(AddBookList);
        }
        public static void AddBook(string Title, string Author, int ReleaseYear)
        {
            Book book = new Book(Title, Author, ReleaseYear);
            BookInventory.Add(book);
        }
        public static List<Book> SearchForBook(string SearchVariable)
        {
            List<Book> BookInventory = GetBookInventory();
            List<Book> tempList = new List<Book>();

/* ------------------------------- Find Title ------------------------------- */
            tempList.AddRange(BookInventory.FindAll(
                delegate(Book bk)
                {
                    return bk.Title.ToLower() == SearchVariable.ToLower();
                }
                ));

/* ------------------------------- Find Author ------------------------------ */
            tempList.AddRange(BookInventory.FindAll(
                delegate(Book bk)
                {
                    return bk.Author.ToLower() == SearchVariable.ToLower();
                }
                ));

/* ---------------------------- Find ReleaseYear ---------------------------- */
            tempList.AddRange(BookInventory.FindAll(
                delegate(Book bk)
                {
                    return bk.ReleaseYear == Convert.ToInt32(SearchVariable);
                }
                ));

            return tempList;
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