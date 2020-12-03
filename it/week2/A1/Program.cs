using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1
{
    class Program
    {

        protected delegate double TaxCalculator(double s);
        static void Main(string[] args)
        {
            Program p = new Program();
            TaxCalculator t = p.TaxIndia;
            

            double salary = 40000;

            Console.WriteLine("Tax in India is  {0}", t(salary));

            t = p.TaxUS;

            Console.WriteLine("Tax in USA is  {0}", t(salary));

            Console.Read();
        }

        private double TaxIndia(double salaray)
        {
            double tax;
            if(salaray < 100000)
            {
                tax = 0.0;
            }
            else if(salaray < 500000)
            {
                tax =  0.1 * salaray;
            }
            else
            {
                tax =  50000 + 0.2 * (salaray - 500000);
            }
            return tax;
        }

        private double TaxUS(double salaray)
        {
            double tax;
            if (salaray < 20000)
            {
                tax = 0.0;
            }
            else if (salaray < 50000)
            {
                tax = 0.1 * salaray;
            }
            else
            {
                tax = 5000 + 0.2 * (salaray - 50000);
            }
            return tax;
        }
    }
}
