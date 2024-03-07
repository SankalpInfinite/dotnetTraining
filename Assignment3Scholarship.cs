using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Scholarship
    {
        double Amount;
        public void Merit(int Marks,int Fees) {

            if (Marks >= 70 && Marks <= 80)
                Amount = (.2 * Fees);
            else if (Marks > 80 && Marks <= 90)
                Amount = (.3 * Fees);
            else if (Marks > 90)
                Amount = (.5 * Fees);
            else
                Amount = 0;
            Console.WriteLine($"Your Scholarship Amount is {Amount}");
        }

        public static void Main()
        {
            Scholarship sc = new Scholarship();
            Console.WriteLine("Enter Your Marks");
            int Marks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Fees");
            int Fees = int.Parse(Console.ReadLine());
            sc.Merit(Marks, Fees);
            Console.ReadKey();

        }


    }
}
