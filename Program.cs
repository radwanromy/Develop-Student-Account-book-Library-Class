using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Information");
            Console.WriteLine();
            Console.WriteLine();
            Student s = new Student("Radwan", "0001", "CSE",3);

            s.ShowInfo();
            Console.WriteLine();
            Console.WriteLine("Account Information");
            Console.WriteLine();
            Console.WriteLine();
            Account a = new Account("Radwan","1212",11000);
            a.ShowInfo();
            Console.WriteLine();
            Console.WriteLine("Book Information");
            Console.WriteLine();
            Console.WriteLine();
            Book b = new Book("HP", "JKR", "001","Ad");
            b.ShowInfo();
        }
    }
}