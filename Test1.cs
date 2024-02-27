using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Test1
    {
        public  Boolean checkequal(int a, int b)
        {
            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void PositiveandNegative(int n)
        {
            if (n > 0)
            {
                Console.WriteLine("The given no is positive");
            }
            else
            {
                Console.WriteLine("The given no is negative");
            }
            Console.ReadLine();
        }
        public int operation(int a, int b, char op)
        {
            switch (op)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    return a / b;
                default:
                    return 0;
            }
        }
        public static void Tables(int n)
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} * {i} =" + (i * n));
            }
        }
        public static void Triple(int n,int m)
        {
            Test1 t = new Test1();
            if (t.checkequal(n, m) == true)
            {
                Console.WriteLine((n + n + n));
            }
            else
            {
                Console.WriteLine("Not Equals");
            }
        }
        public static void Day(int n)
        {
            switch (n)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }
    }
}
