using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Question3
    {
        public static void sample(int x,int y,int z)
        { int max = -1;
            Console.WriteLine($"the input no are {x} {y} {z}");
            if (x>= y&& x>=z)
            {
                max = x;
            }
            else if(y >= x && y >= z)
            {
                max = y;
            }
            else
            {
                max = z;
            }
            Console.WriteLine($"Maximum no is {max}");
            Console.WriteLine("-----------------------");
        }
    }
}
