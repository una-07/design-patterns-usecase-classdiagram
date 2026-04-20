using System.Collections.Generic;
using LibrarySystem.Models;

namespace LibrarySystem.Users
{
    public class Librarian : User
    {
        public void AddBook(List<Book> books, Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(List<Book> books, Book book)
        {
            books.Remove(book);
        }
    }
}
