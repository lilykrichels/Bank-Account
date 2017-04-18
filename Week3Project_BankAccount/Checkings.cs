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
//there are no fields in the checkings class, they all draw from the MainAccount

        //PROPERTIES
//there are no properties

        //CONSTRUCTORS
//this is telling the program to go into the MainAccout and get these value
//it has to be named after the class it's part of
        public Checkings(string accountNum, double balance, double minBalance, string accountName) : base(accountNum, balance, minBalance, accountName)
        {
//this is the checking accounts starting balance and is equal to one pile of gold accoring to 
//https://thebillfold.com/how-much-money-you-need-to-realistically-recreate-the-scrooge-mcduck-gold-coin-swim-e05b6e773b0e
        }

        //METHODS 
        
//this method will charge a $5 transaction fee whenever the person withdraws from their checkings account

        public override void TransactionFee()
        {
            this.Balance -= 5.00;
        }

    }
}
