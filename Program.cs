using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!..Welcome to C#");
            Console.WriteLine("Enter Your First Name:");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter your Last Name:");
            string lname = Console.ReadLine();
            Console.WriteLine("Your FirstName is : " + fname + "and your LastName is : " + lname); //concatenation
            Console.WriteLine("Your FirstName is :{0} and your LastName is :{1}", fname, lname); //place holders

            //create an object of the Program class and call its function
            Program program = new Program();
            program.type_Conversions();
            program.Ref_value_conversion();
            program.Nullable_Eg();
            Day2 Si = new Day2();
            int sum = Si.AddNos(5, 6);  //calling an instance method with the help of an object of the class
            Console.WriteLine("The Sum of 2 Nos :{0}", sum);
            Day2.EvenNos_Generation(20);
            Console.WriteLine("===============");
            TestClass.Method1();
            Console.ReadKey();

            ProgramConstructs pc = new ProgramConstructs();
            pc.CheckGrades();
            pc.CheckGrades_With_Switch();
            Loops loops = new Loops();
            Console.WriteLine("------While Loop------");
            loops.WhileLoop();
            Console.WriteLine("------For Loop------");
            loops.ForLoop();
            Console.WriteLine("------Do While Loop------");
            Loops.DoWhileLoop();

            Console.Read();

        }

        //lets write another function to understand data conversions
        public void type_Conversions()
        {
            int i = 100;
            float f;
            Console.WriteLine(i);
            f = i;  //implicit conversion
            Console.WriteLine(f);
            f = 12345.56f;
            int x = (int)f; //explicit using cast operator
            Console.WriteLine(x);
            // x = Convert.ToInt32(f); //using conversion function
            Console.WriteLine(x);

            //if we change the value of f to a bigger number, then we see that 
            //casting operator displays the max capacity of an integer data type
            //where as the conversion function throws an exception of overflow

            //now let us use parse and tryparse() to understand string conversions

            string str = "250g";
            // x = int.Parse(str);
            // Console.WriteLine("Value of X after parsing is " + x);

            /*the above parse functions throws an exception when unable to parse a string
                To avoid exception we can use tryParse(), whcih does not throw exception even 
            when unable to parse a string to integer             
             */
            int result;
            bool success = int.TryParse(str, out result);

            if (success)
            {
                Console.WriteLine("The Parsed Number is {0}", result);
            }
            else
                Console.WriteLine("Invalid Data..Could not Parse");

        }

        public void Ref_value_conversion()
        {
            int i = 10;  //value type
            object o;  //reference type

            o = i;  //boxing
            Console.WriteLine(o);
            i = (int)o;   //unboxing with a cast

            float Marks;
            Console.WriteLine("Enter Marks :");
            Marks = float.Parse(Console.ReadLine());  //unboxing
            Console.WriteLine("Marks thru Parse" + " " + Marks);
            //the above can also be written using conversion function as below

            Console.WriteLine("Enter Marks :");
            Marks = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Marks Thru Conversion " + " " + Marks);
            string s1 = "ABC";
            o = s1;   //implicit between 2 objects
            Console.WriteLine(s1);
            Console.WriteLine(o);
        }

        public void Nullable_Eg()
        {
            string str = null;
            int? num1 = 80;
            int num2;

            if (num1 == null)
            {
                num2 = 0;
            }
            else
                num2 = Convert.ToInt32(num1); //or as below
                                              //  num2 = (int)num1;

            Console.WriteLine(num2);

            //the above 8 lines of code can be replaced in asingle line 
            //using null coalescing operator (??)
            Console.WriteLine("-------------------");
            num2 = num1 ?? 0;
            Console.WriteLine(num2);
        
    }
    }
}
