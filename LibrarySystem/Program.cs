using System;
using LibrarySystem;
using LibrarySystem.Models;
using LibrarySystem.Users;

class Program
{
    static void Main()
    {
        var library = new Library();

        var book1 = new Book { Title = "Clean Code" };
        var book2 = new Book { Title = "Design Patterns" };

        var reader = new Reader { Name = "Ali" };

        library.AddBook(book1);
        library.AddBook(book2);
        library.RegisterReader(reader);

        Console.WriteLine("Books in library:");
        library.ShowBooks();

        Console.WriteLine("\nBorrowing book...");
        reader.BorrowBook(book1);

        library.ShowBooks();

        Console.WriteLine("\nReturning book...");
        reader.Loans[0].ReturnBook();

        library.ShowBooks();
    }
}
