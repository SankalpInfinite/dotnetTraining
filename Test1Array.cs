using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Test1Array
    {
        public static void question1(params int[] arr)
        {
            int avg = 0, max = 0, min = arr[0], count = 0;
            foreach (int n in arr)
            {
                Console.WriteLine(n);
                avg += n;
                count++;
                if (min > n)
                    min = n;
                if (max < n)
                    max = n;
            }
            avg = avg / count;
            Console.WriteLine($"Minimun no is {min}");
            Console.WriteLine($"Maximum no is {max}");
            Console.WriteLine($"Average of no is {avg}");
        }
        public static void AcceptTen()
        {
            int[] arr = new int[10];
            int count = 0, total = 0;
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Enter the no");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                //intArray.Length - 2
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    count = count + 1;
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("ascending order");
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine(arr[i]);
                total = total + arr[i];
            }
            Console.WriteLine("Descending Order");
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine($"Max is {arr[9]}");
            Console.WriteLine($"Min is {arr[0]}");
            Console.WriteLine($"Total is {total}");
            Console.WriteLine($"Averge is {total / 10}");
        }
        public static void copy()
        {
            for (int i = 0; i <= 9; i++)
            {
                int[] arr = new int[10];
                Console.WriteLine("Enter the no");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] arr1 = new int[10];
            for (int i = 0; i <= 9; i++)
            {
                arr1[i] = arr1[i];
            }

        }

    }
}
