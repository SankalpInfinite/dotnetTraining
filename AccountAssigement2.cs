using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigement2
{
    class Account
    {
        int Account_no;
        string Customer_name;
        string Account_type;
        double balance;

       public Account(int Account_no,string Customer_name,string Account_type,double balance)
        {
            this.Account_no = Account_no;
            this.Customer_name = Customer_name;
            this.Account_type = Account_type;
            this.balance = balance;
        }
        public void Transaction_Type(char Transaction_type, double amount)
        {
            if (Transaction_type=='D')
            {
                balance += amount;
            }
            else if (Transaction_type=='W')
            {
                balance -= amount;
            }else
                {
                Console.WriteLine("Enter amount and D for Deposite or W for Withdrawal");
            }
        }
        public void show()
        {
            Console.WriteLine($"Name of Coustmer : {Customer_name}");
            Console.WriteLine($"Account No of Coustmer : {Account_no}");
            Console.WriteLine($"Account Type of Coustmer : {Account_type}");
            Console.WriteLine($"Account Final Balance of Coustmer : {balance}");
        }
    }
}
