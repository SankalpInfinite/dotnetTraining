using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Day2
    {
        public int AddNos(int a, int b) //Instance Method
        {
            Console.WriteLine(a + b);
            return a + b;
        }

        public static void EvenNos_Generation(int num)  //static Method
        {
            int i = 0;
            while (i <= num)
            {
                Console.WriteLine(i);
                i += 2;
            }
        }
    }
    class TestClass
    {
        public static void Method1()
        {
            Console.WriteLine("This is a static function of another class");
        }
    }
    class ProgramConstructs
    {
        //if else
        public void CheckGrades()
        {
            char grade;
            int maths = 100;
            Console.WriteLine("Enter your Grade O/A/B/C/D");
            grade = Convert.ToChar(Console.ReadLine());
            if ((grade == 'O' || grade == 'o') && (maths > 90))
                Console.WriteLine("Outstanding");
            else if (grade == 'A')
                Console.WriteLine("Excellent");
            else if (grade == 'B')
                Console.WriteLine("Very Good");
            else if (grade == 'C')
                Console.WriteLine("Good");
            else if (grade == 'D')
                Console.WriteLine("Can Improve");
            else
                Console.WriteLine("Invalid Grade");
        }

        public void CheckGrades_With_Switch()
        {
            char grade; int math;
            Console.WriteLine("Enter Grade and maths Score");
            grade = Convert.ToChar(Console.ReadLine());
            math = Convert.ToInt32(Console.ReadLine());
            switch (grade)
            {
                case 'O':
                case 'o':
                    Console.WriteLine("outstanding");
                    break;
                case 'A':
                case 'a':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                case 'b':
                    Console.WriteLine("Very Good");
                    break;
                case 'C':
                case 'c'
:
                    Console.WriteLine("Good");
                    break;
                case 'D':
                case 'd':
                    Console.WriteLine("Can Improve");
                    break;
                default:
                    Console.WriteLine("invalid Grade");
                    break;
            }
        }
    }
    class Loops
    {
        //iterations
        public void WhileLoop()
        {
            int i = 1;
            while (i < 5)
            {
                Console.Write(i);
                i++;
            }
            Console.WriteLine();
        }

        public static void DoWhileLoop()
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);
        }

        public void ForLoop()
        {
            int tot = 0;
            for (int i = 0; i <= 5; i++)
            {
                if (i == 3)
                    //break;
                    continue;
                tot += i;
            }
            Console.WriteLine("Sum of all numbers {0}", tot);
        }

    }
}
