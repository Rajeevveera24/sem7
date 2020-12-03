using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            TrafficSignal t = new TrafficSignal();
            TrafficSignal.TrafficDel del = t.Yellow;
            del += t.Green;
            del += t.Red;

            del();

            Console.Read();
        }
    }

    class TrafficSignal
    {
        public delegate void TrafficDel();
        public void Yellow()
        {
            Console.WriteLine("Yellow is for stopping and looking");
        }
        public void Green()
        {
            Console.WriteLine("Green is for going");
        }
        public void Red()
        {
            Console.WriteLine("Red is for completely stopping");
        }
    }
}
