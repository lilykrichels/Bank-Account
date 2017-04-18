using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Week3Project_BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the National Bank of Duckburg Mr. McDuck. \n");
     
            Client client1 = new Client();          
            Checkings checkings1 = new Checkings("1234", 486000.00d, 0.0, "Checking");
            Savings savings1 = new Savings("1235", 31200000000.00d, 500.0, "Savings");

            do
            {
                Console.WriteLine("Please select from the following options:\n");
                Console.WriteLine("\t 1 = View Client Info");
                Console.WriteLine("\t 2 = View Account Balance");
                Console.WriteLine("\t 3 = Deposit Funds");
                Console.WriteLine("\t 4 = Withdraw Funds");
                Console.WriteLine("\t 5 = Exit");
                //the prints the counsole that user will pick from

                int selectedOption;
            selectedOption = int.Parse(Console.ReadLine());
                //i decided to use a switch case that ran a transaction depending what the user choose
            switch (selectedOption)
            {
                case 1:
                
                client1.PrintClientInfo();
                //This just prints the users info, which is hardcoded into the client base class 
                    break;

                case 2:
                       //this will let the user view their account balances 
                        Console.WriteLine("\t To view your checkings balance, press 1");
                        Console.WriteLine("\t To view your savings balance, press 2");
                        int account = int.Parse(Console.ReadLine());
                        if (account == 1)
                        {
                            Console.WriteLine(checkings1.Balance);
                        }
                           
                        else if (account == 2)
                       {
                            Console.WriteLine(savings1.Balance);
                       }
                        break;
               case 3: 
                        //action will allow user to put money into their checkings or savings account
                        Console.WriteLine("\t To deposit funds into your checkings account, press 1");
                        Console.WriteLine("\t To deposit funds into you savings account, press 2");
                        int accountDeposit = int.Parse(Console.ReadLine());
                        

                        if (accountDeposit == 1)
                        {
                            //once the user picks an account then they will be prompted to input an amount
                           //the new amount will print out automatically 
                            Console.WriteLine("\t How much would you like to deposit into your checkings account?\n");
                            double deposit = double.Parse(Console.ReadLine());
                            checkings1.Deposit(deposit);
                            Console.WriteLine("\tYou're new checkings balance is " + "$" + checkings1.Balance);

                        }
                        else if (accountDeposit == 2)
                        {
                            Console.WriteLine("\t How much would you like to deposit into you savings account?\n");
                            double deposit = double.Parse(Console.ReadLine());
                            savings1.Deposit(deposit);
                            Console.WriteLine("\tYou're new savings balance is " + "$" + savings1.Balance);
                        }
                        break;
                    case 4:
                        Console.WriteLine("To withdraw funds from your checkings account press 1.");
                        Console.WriteLine("To withdraw funds from your savings account press 2.");
                        int withdrawlAccount = int.Parse(Console.ReadLine());

//to make a withdrawl the person has to select an account 
//i then used a bool to make sure that an error message comes up if the person does not have enough money 
//There is also a method that takes out a transaction fee for each withdrawl  //There is a higher penalty for withdrawing from the savings account.

                        if (withdrawlAccount == 1)
                        {
                            Console.WriteLine("How much would you like to withdrawl from your checkings account?\n");
                            double withdrawl = double.Parse(Console.ReadLine());
                            bool results = checkings1.Withdrawl(withdrawl);                           
                            if (results)
                            {
                                checkings1.TransactionFee();
                                Console.WriteLine("\tYour new balance is $" + checkings1.Balance + "\n");

                            }
                            else
                            {
                                Console.WriteLine("\tYou have insufficient funds to make this transaction.\n");
                            }
                        }
                        if (withdrawlAccount == 2)
                        {
                            Console.WriteLine("How much would you like to withdrawl from your savings account?\n");
                            double withdrawl = double.Parse(Console.ReadLine());
                            bool results = savings1.Withdrawl(withdrawl);
                            if (results)
                            {
                                savings1.TransactionFee();
                                Console.WriteLine("\tYour new balance is $" + savings1.Balance + "\n");
                            }
                            else
                            {
                                Console.WriteLine("\tYou have insufficient funds to make this transaction.\n");
                            }
                        }
                        break;

                    case 5:
//this will exit and restart the application
                        Console.WriteLine("\tThank you for visiting the National Bank of DucksBurg.\n");
                        Thread.Sleep(3000);
                        Environment.Exit(0); 


                        break;
                }      

            } while (true);
    
            
        }
    }
}
