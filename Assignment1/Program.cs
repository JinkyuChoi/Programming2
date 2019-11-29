using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Person
    {
        private string _name;

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public Person(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
            //DC -1 don't use string concatenation
            _name = FirstName + ' ' + LastName;
        }

        public override string ToString()
        {
           return string.Format(_name);
        }
    }

    //DC you should put each class in a different file
    public class BankAccount
    {
        public Person Owner
        {
            get;
            private set;
        }

        public double Balance
        {
            get;
            private set;
        }

        public static double InterestRate
        {
            get;
            private set;
        }

        public BankAccount(Person owner, double balance, double interestRate)
        {
            Owner = owner;
            Balance = balance;
            InterestRate = interestRate;
        }

        public double Deposit(double deposit)
        {
           Balance += deposit;
           return Balance;
        }

        public double Withdrawal(double withdrawal)
        {
            Balance -= withdrawal;
            return Balance;
        }

        public double DepositInterest()
        {
            Balance += Balance * (InterestRate / 100);
            return Balance;
        }

        public override string ToString()
        {
            return string.Format("Owner : {0}\nBalance : {1:f2}", Owner, Balance);
        }
    }

    class Program
    {
        static void Main(string[] args)
        { 

        }
    }
}
