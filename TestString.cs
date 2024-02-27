using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class TestString
    {
        public static void name()
        {
            Console.WriteLine("Enter Word");
            string m = Console.ReadLine();
            Console.WriteLine($"Your Word length is{m.Length}");
        }
        public static void Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine((charArray));
        }
        public static void SameOrNot(String a, String b)
        {
          
            char[] ch1 = a.ToCharArray();
            char[] ch2 = b.ToCharArray();
            //Array.Sort(ch1);
            //Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if (val1 == val2)
            {
                Console.WriteLine("Both the strings are Same");
            }
            else
            {
                Console.WriteLine("Both the strings are not Same");
            }
        }

    }
}
