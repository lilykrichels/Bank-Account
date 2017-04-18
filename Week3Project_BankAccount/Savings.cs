using System;

namespace Week3Project_BankAccount
{
    class Savings : MainAccount
    {
        //FIELDS
        //private double interest;
        //private double addDeposit = Convert.ToDouble(Console.ReadLine());

       
        //CONSTRUCTORS
        public Savings(string accountNum, double balance, double minBalance,  string accountName) : base (accountNum, balance, minBalance, accountName)
        {
            //this is the amount of gold estimated to be in Scrooge McDuck's vault source:
            //https://thebillfold.com/how-much-money-you-need-to-realistically-recreate-the-scrooge-mcduck-gold-coin-swim-e05b6e773b0e
        }


        //METHODS 
        public override void TransactionFee()
        {
            this.Balance -= 10.00;
        }








        //maybe add these back later???
        //public override double AddInterest()
        //{
        //    interest = SavingsBal * .02;//this method will calculate the interest in the savings account, which is 1.5%
        //    return interest;
        //}

        //public void PrintInterest()
        //{
        //    Console.WriteLine("You're account has gained " + interest + " in interest.");
        //}




    }
}
