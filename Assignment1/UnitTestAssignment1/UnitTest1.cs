using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAssignment1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateEmptyAccount()
        {
            string fName = "Hyukjae";
            string lName = "Lee";
            double balance = 0;
            const double interestRate = 0;

            Assignment1.Person owner = new Assignment1.Person(fName, lName);
            Assignment1.BankAccount bankAccount = new Assignment1.BankAccount(owner, balance,interestRate);

            Assert.AreEqual("Hyukjae", owner.FirstName);
            Assert.AreEqual("Lee", owner.LastName);
            Assert.AreEqual(0, bankAccount.Balance);
        }

        [TestMethod]
        public void CreateNonEmptyAccount()
        {
            string fName = "Hyukjae";
            string lName = "Lee";
            double balance = 500;
            const double interestRate = 0;

            Assignment1.Person owner = new Assignment1.Person(fName, lName);
            Assignment1.BankAccount bankAccount = new Assignment1.BankAccount(owner, balance, interestRate);

            Assert.AreEqual("Hyukjae", owner.FirstName);
            Assert.AreEqual("Lee", owner.LastName);
            Assert.AreEqual(500, bankAccount.Balance);
        }

        [TestMethod]
        public void DepositEmptyAccount()
        {
            string fName = "Hyukjae";
            string lName = "Lee";
            double balance = 0;
            double deposit = 37;
            const double interestRate = 0;

            Assignment1.Person owner = new Assignment1.Person(fName, lName);
            Assignment1.BankAccount bankAccount = new Assignment1.BankAccount(owner, balance, interestRate);
            bankAccount.Deposit(deposit);

            Assert.AreEqual("Hyukjae", owner.FirstName);
            Assert.AreEqual("Lee", owner.LastName);
            Assert.AreEqual(37, bankAccount.Balance);
        }

        [TestMethod]
        public void DepositNonEmptyAccount()
        {
            string fName = "Hyukjae";
            string lName = "Lee";
            double balance = 500.00;
            double deposit = 37.00;
            const double interestRate = 0;

            Assignment1.Person owner = new Assignment1.Person(fName, lName);
            Assignment1.BankAccount bankAccount = new Assignment1.BankAccount(owner, balance, interestRate);
            bankAccount.Deposit(deposit);

            Assert.AreEqual("Hyukjae", owner.FirstName);
            Assert.AreEqual("Lee", owner.LastName);
            Assert.AreEqual(537, bankAccount.Balance);
        }

        [TestMethod]
        public void WithdrawalNonEmptyAccount()
        {
            string fName = "Hyukjae";
            string lName = "Lee";
            double balance = 500.00;
            double withdrawal = 300.00;
            const double interestRate = 0;

            Assignment1.Person owner = new Assignment1.Person(fName, lName);
            Assignment1.BankAccount bankAccount = new Assignment1.BankAccount(owner, balance, interestRate);
            bankAccount.Withdrawal(withdrawal);

            Assert.AreEqual("Hyukjae", owner.FirstName);
            Assert.AreEqual("Lee", owner.LastName);
            Assert.AreEqual(200, bankAccount.Balance);
        }

        [TestMethod]
        public void DepositInterestEmptyAccount()
        {
            string fName = "Hyukjae";
            string lName = "Lee";
            double balance = 0;
            const double interestRate = 2.5;

            Assignment1.Person owner = new Assignment1.Person(fName, lName);
            Assignment1.BankAccount bankAccount = new Assignment1.BankAccount(owner, balance, interestRate);
            bankAccount.DepositInterest();

            Assert.AreEqual("Hyukjae", owner.FirstName);
            Assert.AreEqual("Lee", owner.LastName);
            Assert.AreEqual(0, bankAccount.Balance);
        }

        [TestMethod]
        public void DepositInterestNonEmptyAccount()
        {
            string fName = "Hyukjae";
            string lName = "Lee";
            double balance = 500.00;
            const double interestRate = 2.5;

            Assignment1.Person owner = new Assignment1.Person(fName, lName);
            Assignment1.BankAccount bankAccount = new Assignment1.BankAccount(owner, balance, interestRate);
            bankAccount.DepositInterest();

            Assert.AreEqual("Hyukjae", owner.FirstName);
            Assert.AreEqual("Lee", owner.LastName);
            Assert.AreEqual(512.5, bankAccount.Balance);
        }
    }
}
