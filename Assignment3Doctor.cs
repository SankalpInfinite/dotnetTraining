using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Doctor
    {
        private int RegnNo;
        private String Name;
        private double Feescharged;

         public void Display(int RegnNo, String Name, double Feescharged)
        {
            this.RegnNo = RegnNo;
            this.Name = Name;
            this.Feescharged = Feescharged;

            Console.WriteLine($"The Name of the Doctor is dr. {Name}");
            Console.WriteLine($"The RegnNo  of the dr. {Name} is  {RegnNo}");
            Console.WriteLine($"The Fess Charge by the dr. {Name} is  {Feescharged}");

        }
        public static void Main() {

            Console.WriteLine("The Name of the Doctor");
            string Name = Console.ReadLine();
            Console.WriteLine($"The RegNo of the dr. {Name}");
            int REgNo = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter the Fess Charge by dr. {Name}");
            double FeesCharge = Convert.ToDouble(Console.ReadLine());

            Doctor dr = new Doctor();
            dr.Display(REgNo,Name,FeesCharge);
            Console.ReadKey();
        
        }
    }
}
