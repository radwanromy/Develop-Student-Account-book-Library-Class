using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Library
    {
        string libName;
        public string LibName
        {
            set { libName = value; }
            get { return libName; }
        }
        private string libAddress;
        public string LibAddress
        {
            get { return libAddress; }
            set { libAddress = value; }
        }

        private int totalBook;

        public int TotalBook
        {
            get { return totalBook; }
            set { totalBook = value; }
        }
        private Book[] accounts;
        private int bookCount;
        public int BookCount
        {
            get { return bookCount; }
            set { bookCount = value; }
        }

        public Library()
        {
            accounts = new Book[10];
            bookCount = 0;
            Console.WriteLine("Library Default");
        }
        public Library(string libName, string libAddress, int totalBook)
        {
            this.libName = libName;
            this.libAddress = libAddress;
            this.totalBook = totalBook;
            Console.WriteLine("Book Valued Constructor");
            accounts = new Book[10];
            bookCount = 0;
        }
        public void AddBook(params Book[] accounts)
        {
            foreach (var a in accounts)
            {
                if (bookCount < 10)
                {
                    this.accounts[bookCount++] = a;
                    Console.WriteLine("Book Added");
                }
                else
                {
                    Console.WriteLine("Cannot Add Book:  " + a.BookCopy);
                }
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Library Name: " + libName);
            Console.WriteLine("Library Address: " + libAddress);
            Console.WriteLine("Total Books: " + totalBook);
        }

    }
}