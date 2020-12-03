using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result = 0;
            char c;
            Console.WriteLine("Enter the numbers followed by the operator:");
            string n1 = Console.ReadLine(); // Readline() method returns string type
            string n2 = Console.ReadLine();
            string op = Console.ReadLine();
            int.TryParse(n1, out num1);
            int.TryParse(n2, out num2);
            char.TryParse(op, out c);

            if(c == '+')
            {
                result = num1 + num2;    
            }
            else if(c == '-')
            {
                result = num1 - num2;
            }
            else if(c == '*')
            {
                result = num1 * num2;
            }
            else if(c == '/')
            {
                result = num1 / num2;
            }
            else if(c == '%')
            {
                result = num1 % num2;
            }
            else
            {
                Console.WriteLine("Please enter a proper operator");
            }

            Console.WriteLine("{0} {2} {1} = {3}", num1, num2, c, result);
            Console.Read(); // Read() accepts only single character
        }
    }
}
