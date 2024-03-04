using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigement2
{
    class Student
    {
        int Rollno, _class, Semester;
        string Name, Branch;
        int[] marks = new int[5];
        public Student(int Rollno, string Name, int _class, int Semester, string Branch)
        {
            this.Rollno = Rollno;
            this.Name = Name;
            this._class = _class;
            this.Semester = Semester;
            this.Branch = Branch;
        }
        public void GetMarks(int[] m)
        {
            for (int i = 0; i < 5; i++)
            {
                marks[i] = m[i];
            }

        }
        public void DisplayResult()
        {
            
            if (MarksCheck() == false)
            {
                Console.WriteLine("Failed");
            }
            else if (Avg()<50&&MarksCheck()==false)
            {
                Console.WriteLine("Failed");
            }else
            {
                Console.WriteLine("Passed");
            }
        }
        public double Avg()
        {
            int total = 0;
            for(int i = 0; i < 5; i++)
            {
                total += marks[i];
            }
            return total / 5;
        }
        public Boolean MarksCheck()
        {
            Boolean x = true;
            for (int i = 0; i < 5; i++)
            {
                if (marks[i] > 35)
                    continue;
                else
                return false;

            } return true;

        }
        public void DisplayData()
        {
            Console.WriteLine($"Roll no of Student is : {Rollno}");
            Console.WriteLine($"Name of Student is : {Name}");
            Console.WriteLine($"Semester of Student is : {Semester}");
            Console.WriteLine($"Class of Student is : {_class}");
            Console.WriteLine($"Branch of Student is : {Branch}");
            for(int i = 0; i < 5; i++) {
                Console.WriteLine($"Marks of {i} subject is: {marks[i]}");
            }
            
        }

    }
}
