using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2
{
    class Program
    {
        static void Main(string[] args)
        {
            EBBill bill = new EBBill();
            EBBill.metreRent = 100;
            bill.ownerName = "Rajeev";
            bill.houseNumber = 1017;
            bill.unitsConsumed = 345;
            Console.WriteLine("The electricity bill is {0}", bill.calcBill());

            Console.Read();
        }
    }

    class EBBill
    {
        public string ownerName { get; set;}
        public int houseNumber { get; set; }
        public int unitsConsumed{get; set;}
        public static float metreRent;

        public double calcBill()
        {
            return this.unitsConsumed * 1.2 + metreRent;
        }
    }
}
