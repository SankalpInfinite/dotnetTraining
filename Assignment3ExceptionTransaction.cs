using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class ExceptionTransaction: ApplicationException
    {
        public ExceptionTransaction(String Message) : base(Message) { }
    }
    class Transaction
    {
        int WithDraw_Amount, Balance;
        public Transaction(int Balance)
        {
            this.Balance = Balance;
        }
        public void Check(int WithDraw)
        {
            WithDraw_Amount = WithDraw;
            if (Balance - WithDraw_Amount < 0)
            {
                throw (new ExceptionTransaction("You does not have Sufficent Balance"));
            }
            else
            {
                Console.WriteLine("Transaction Sucessfull");
            }
        }
    }
    class HandlingException
    {
        public static void Main()
        {
            Console.WriteLine("Enter the total Amount");
            int Balance = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the WithDraw Amount");
            int WithDraw = int.Parse(Console.ReadLine());

            Transaction t = new Transaction(Balance);
            try {
                t.Check(WithDraw);
            }
            catch(ExceptionTransaction et)
            {
                Console.WriteLine(et.Message);
            }
            Console.ReadKey();
        }
    }
}
