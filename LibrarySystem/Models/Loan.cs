using System;
using LibrarySystem.Users;

namespace LibrarySystem.Models
{
    public class Loan
    {
        public Book Book { get; set; }
        public Reader Reader { get; set; }
        public DateTime LoanDate { get; set; }

        public Loan(Book book, Reader reader)
        {
            Book = book;
            Reader = reader;
            LoanDate = DateTime.Now;
        }

        public void ReturnBook()
        {
            Book.ChangeAvailability(true);
        }
    }
}
