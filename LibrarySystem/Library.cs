using System;
using System.Collections.Generic;
using LibrarySystem.Models;
using LibrarySystem.Users;

namespace LibrarySystem
{
    public class Library
    {
        public List<Book> Books { get; set; } = new List<Book>();
        public List<Reader> Readers { get; set; } = new List<Reader>();

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void RegisterReader(Reader reader)
        {
            Readers.Add(reader);
        }

        public void ShowBooks()
        {
            foreach (var book in Books)
            {
                Console.WriteLine($"{book.Title} - Available: {book.IsAvailable}");
            }
        }
    }
}
