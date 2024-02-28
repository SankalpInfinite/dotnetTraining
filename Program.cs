using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Question1.Sample("python",1);
            Question1.Sample("python", 0);
            Question1.Sample("python", 4);


            Question2.sample("abcd");
            Question2.sample("ab");
            Question2.sample("a");


            Question3.sample(1,2,3);
            Question3.sample(1, 3, 2);
            Question3.sample(1, 1, 1);
            Question3.sample(1, 2, 2);
            Console.ReadLine();
        }
    }
}
