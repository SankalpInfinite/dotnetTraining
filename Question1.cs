using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Question1
    {
        public static void Sample(string str,int n)
        {
            string str1 = "";
            for(int i = 0; i < str.Length; i++)
            {
                if (i == n)
                    continue;
                else
                    str1 += str[i];
            }
            Console.WriteLine($"The Original String is {str}");
            Console.WriteLine($"The updated String is {str1}");
            Console.WriteLine($"--------------------------------------");
        }
    }
}
