using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Project_BankAccount
{
   public abstract class MainAccount //adding public abstract before call allows us to use an abstract method anywhere later on 
       
    {
        //FIELDS; these are protected because we do not want anyone to access these besides the child classes
        private string accountNum;
        private double balance;
        private double minBalance; 
        private string accountName;

        //PROPERTIES; these are always public
        public string AccountNum
        {
            get { return this.accountNum; }
            set { this.accountNum = value;  }
        }

        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public double MinBalance
        {
            get { return this.minBalance; }
            set { this.minBalance = value; }
        }

        public string AccountName
        {
            get { return this.accountName; }
            set { this.AccountName = value; }
        }


        //CONSTRUCTORS
        public MainAccount()
        {

        }

        public MainAccount(string accountNum, double balance, double minBalance, string accountName)
        {
            this.accountNum = accountNum;
            this.balance = balance;
            this.minBalance = minBalance; 
            this.accountName = accountName;
        }



        //METHODS; these can be called upon by the program and will return a value, but keep the child classes protected 

        //        public void ViewBalance();
        //        {
        //            Console.WriteLine(balance);
        //        }

        public virtual void Deposit(double amount)
        {
            balance += amount;
        }

        public virtual bool Withdrawl(double amount) //this will return an answer depending on the users account balance. 
        {
            double newBal = this.balance - amount;
            if (newBal <= this.minBalance)
            {
                return false;
            }
            else
            {
                balance -= amount;
                return true;
            } 
        }

        public abstract void TransactionFee(); //this is an abstract method that will be different in the checkings and savings class
                                               //it will charge the user a different fee based everytime they withdraw

        //public virtual double Withdrawl()
        //{
        //    Console.WriteLine("Thank you for making a withdrawl");

        //    return checkingsBal;
        //    //return savingsBal;
        //}
        //public virtual double PrintNewBalance()
        //{
        //    return checkingsBal;
        //    //return savingsBal;
        //}

        //public abstract double AddInterest(); //this needs a ; with no body because it is an abstract 
        //                                      //it makes savings and checking come up with their own method to calculate interest 

    }
    }
