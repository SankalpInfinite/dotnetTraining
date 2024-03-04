using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigement2
{
    class Saledetails
    {
        int SalesNo, ProductNo, Qty;
        double Price,TotalAmount;
        DateTime DateofSale;
        

        public Saledetails(int SalesNo,int ProductNo,double Price,int Qty, DateTime DateofSale)
        {
            this.SalesNo = SalesNo;
            this.ProductNo = ProductNo;
            this.Price = Price;
            this.Qty = Qty;
            this.DateofSale = DateofSale;
        }

       

        public void Sales()
        {
            TotalAmount = Qty * Price;
        }
        public void show()
        {
            Console.WriteLine($"Product No :{ProductNo}");
            Console.WriteLine($"Sales No :{SalesNo}");
            Console.WriteLine($"price :{Price}");
            Console.WriteLine($"Quantity :{Qty}");
            Console.WriteLine($"Date of Sale :{DateofSale}");
            Console.WriteLine($"Total Amount :{TotalAmount}");
        }


    }
}
