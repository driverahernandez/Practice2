using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    public class Library
    {
        private List<Book> Books;
        public Library()
        {
            Books = new List<Book>();
        }
        public void AddBook(Book book) => Books.Add(book);

        // remove by title
        public void RemoveBook(string title){
            foreach (var book in Books)
            {
                if (book.Title == title)
                {
                    Books.Remove(book);
                    break;
                }
                throw new InvalidOperationException("Book with given title was not found.");
            }
        }

        //remove by isbn
        public void RemoveBook(long isbn)
        {
            foreach (var book in Books)
            {
                if (book.Isbn == isbn)
                {
                    Books.Remove(book);
                    break;
                }
                throw new InvalidOperationException("Book with given ISBN was not found.");
            }
        }
        public void displayBooksList()
        {
            if (Books.Count > 0)
            {
                Console.WriteLine("****All books****"); 
                foreach (var book in Books)
                {
                    book.displayDetails();
                    Console.WriteLine();
                }

            }
            else
                Console.WriteLine("No books in the library.");
        }

    }
}
