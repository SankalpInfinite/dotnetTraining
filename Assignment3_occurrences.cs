using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Assignment3_occurrences
    {
        String Sentence;
        public Assignment3_occurrences(String Sentence){
            this.Sentence = Sentence;
            }
        public int count(char ch)
        {
            int counter = 0;
            
            for (int i = 0; i < Sentence.Length; i++)
            {
                if (Sentence[i] == ch)
                    counter++;
            }
            return counter;
        }
        public static void Main()
        {
            int count;
            Console.WriteLine("Enter the Sentence");
            String Sentence = Console.ReadLine()/*.ToUpper()*/;
            
            Console.WriteLine("Enter the character that need to be count");
            char character = Convert.ToChar(Console.Read());
            character = char.ToUpper(character);

            Assignment3_occurrences ao = new Assignment3_occurrences(Sentence);
            count = ao.count(character);
            Console.WriteLine($"The occurance of {character} in {Sentence} is {count}");
            Console.ReadKey();
        }
    }
}
