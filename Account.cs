using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6
{
    class Account
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string accNo;

        public string AccNo
        {
            get { return accNo; }
            set { accNo = value; }
        }
        protected double balance;
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public Account() { }
        public Account(string name,string accNo, double balance)
        {
            this.name = name;
            this.accNo = accNo;
            this.balance = balance;
            Console.WriteLine("Account Valued Constructor");

        }
        public void Deposit(double amount)
        {
            balance += amount;

        }
        public void Withdraw(double amount)
        {
            if (amount < balance)
            {
                balance -= amount;
            }
            else
                Console.WriteLine("Insufficient Balance");
        }
        public void Transfer(double amount , string accNo)
        {
            if (amount < balance)
            {
                balance -= amount;
                Console.Write(amount+" Amount ");
                Console.WriteLine("added the amount in account number "+accNo);
            }
            else
                Console.WriteLine("Insufficient Balance");

        }

        public void ShowInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Account Number: " + accNo);
            Console.WriteLine("Balance : " + balance);
        }
        
    }
}