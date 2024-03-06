using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment
{
    public abstract class assessment2Student
    {
       String Name;
       int StudentId;
       float Grade;
        
        protected assessment2Student(String Name,int StudentId)
        {
           Name = Name;
            StudentId = StudentId;
        }
        abstract public  Boolean Ispassed( float Grade);
    }
    class Undergraduate : assessment2Student
    {
        public Undergraduate(String Name, int StudentId) : base( Name, StudentId) { }
        public override bool Ispassed(float grade)
        {
            if (grade > 70)
                return true;
            return false;
        }
    }
    class Graduate : assessment2Student {
        public Graduate(String Name, int StudentId) : base(Name, StudentId) { }
        public override bool Ispassed(float grade)
        {
            if (grade > 80)
                return true;
            return false;
        }
    }
    class calling
    {
    public static void Main()
    {
            Console.WriteLine("Enter your Name");
            String Name = Console.ReadLine();
            Console.WriteLine("Enter your Student ID");
            int StudentId = Convert.ToInt32(Console.Read());
            Console.WriteLine("Enter your Grade");
            float Grade = float.Parse(Console.ReadLine());
            Graduate g = new Graduate(Name,StudentId);
            Boolean ch= g.Ispassed(Grade);
            if(ch==true)
                Console.WriteLine($" Student is Pass");
            else
                Console.WriteLine($" Student is Fail");


            Undergraduate ug = new Undergraduate(Name, StudentId);
            Boolean ch1 = ug.Ispassed(Grade);
            if (ch == true)
                Console.WriteLine($" Student is Pass");
            else
                Console.WriteLine($" Student is Fail");

            Console.Read();
    }
}
}
