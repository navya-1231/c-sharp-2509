using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleClassExample
{
    public class Book
    {
        public string Title;
        public string Author;
        public string ISBN;

        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }
    }
    public class Library
    {
        private List<Book> books=new List<Book>();

        public void AddBook(Book book) { 
            books.Add(book);
        }

        public void RemoveBook(string isbn)
        {
            books.RemoveAll(b => b.ISBN==isbn);
        }
        public void DisplayBook()
        {
            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}");
            }
        }


    }
}
