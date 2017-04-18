using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Project_BankAccount
{
    class Client
    {
        //FIELDS
        private string name = "Scrooge McDuck";
        private string phoneNum = "555-438-4654"; //this spells 555-GET-GOLD on a phone.
        private string address = "Calisota, Duckburg, USA.\n";
        // source http://mentalfloss.com/article/49630/15-things-you-didnt-know-about-ducktales

        //PROPERTIES


        public string Name
        {
            get { return this.name; }
        }

        public string PhoneNum
        {
            get { return this.phoneNum; }
        }
           
        public string Address
        {
            get { return this.name; }
        }

        //CONSTRUCTORS
        public Client()
        {
        
        }

        public Client(string name, string phoneNum, string address)
        {
            this.name = name;
            this.phoneNum = phoneNum;
            this.address = address;
        }

        //METHODS

        public void PrintClientInfo()  //this method prints the clients info
        {
            Console.WriteLine("\t"+ name);
            Console.WriteLine("\t" + phoneNum);
            Console.WriteLine("\t" + address);
        }

       
    }
}
