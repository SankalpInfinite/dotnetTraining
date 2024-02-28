using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Question2
    {
        public static void sample(string str)
        {
            Console.WriteLine($" orginal String{str}");
            
             if(str.Length > 1) {

                Console.WriteLine(str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1));

            }
            else
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("------------------");
            
        }
    }
}
