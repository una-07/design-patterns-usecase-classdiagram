using System;
using System.Collections.Generic;
using LibrarySystem.Models;

namespace LibrarySystem.Users
{
    public class Reader : User
    {
        public List<Loan> Loans = new List<Loan>();

        public void BorrowBook(Book book)
        {
            if (!book.IsAvailable)
                throw new Exception("Not available");

            book.ChangeAvailability(false);
            Loans.Add(new Loan(book, this));
        }
    }
}
