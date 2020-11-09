using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6
{
    class Borrow:Book
    {
        private string bookInfo;
        public string BookInfo
        {
            get { return bookInfo; }
            set { bookInfo = value; }
        }
        private Book[] accounts;
        private int bookCount;
        public int BookCount
        {
            get { return bookCount; }
            set { bookCount = value; }
        }
        public Borrow()
        {
            accounts = new Book[10];
            bookCount = 0;
            Console.WriteLine("Library Default");
        }
        public Borrow(string bookInfo, string bookName, string bookAuthor, string bookId, string bookType, int bookCopy) : base(bookName,bookAuthor,bookId,bookType,bookCopy)
        {
            this.bookInfo = bookInfo;
            Console.WriteLine("Book Valued Constructor");
            accounts = new Book[10];
            bookCount = 0;
        }

        public void ShowStudentNameAndBookInfo(params Book[] accounts)
        {
            foreach (var a in accounts)
            {
                if (bookCount < 10)
                {
                    this.accounts[bookCount++] = a;
                    Console.WriteLine("Book Borrowed");
                }
                else
                {
                    Console.WriteLine("Cannot Add Book:  " + a.BookCopy);
                }
            }
        }
        public void ShowBorrowedBookInfo()
        {
            Console.WriteLine("Borrowed Book Info: " + bookInfo);
        }
    }
}
