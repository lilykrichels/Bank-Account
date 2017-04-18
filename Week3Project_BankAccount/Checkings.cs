using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Project_BankAccount
{
    public class Checkings : MainAccount
    {
        //FIELDS
        //private double interest;
        //private double checkingsBal; 
        //private double addDeposit = Convert.ToDouble(Console.ReadLine());
        //private double withdrawl = Convert.ToDouble(Console.ReadLine());

        //PROPERTIES



        //CONSTRUCTORS
        //this is telling the program to go into the MainAccoutn and get these value
        //it has to be named after the class it's part of
        public Checkings(string accountNum, double balance, double minBalance, string accountName) : base(accountNum, balance, minBalance, accountName)
        {
        //this is the checking accounts starting balance and is equal to one pile of gold accoring to 
        //https://thebillfold.com/how-much-money-you-need-to-realistically-recreate-the-scrooge-mcduck-gold-coin-swim-e05b6e773b0e
        }

        //METHODS 

        public override void TransactionFee()
        {
            this.Balance -= 5.00;
        }

   








    }
}
