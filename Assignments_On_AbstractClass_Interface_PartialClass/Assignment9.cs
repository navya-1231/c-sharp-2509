using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_On_Abstract_Class_Interface_PartialClass
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }
    public class Library
    {
        private Book[] books = new Book[5];

        // Indexer
        public Book this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }

        // Display all books
        public void DisplayBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title},{book.Author}");
            }
        }
    }
}