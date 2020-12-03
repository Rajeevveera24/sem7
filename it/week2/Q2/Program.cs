using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Item.Cost = 100;
            Item i = new Item();
            Console.WriteLine("GST iS {0}", CalcGst(Item.Cost));
            Console.Read();
        }
        private static float CalcGst(float cost)
        {
            return (float)0.08 * cost;
        }
    }

    class Item
    {
        protected string name { get; set; }
        private static float cost;

        public static float Cost {
            get
            {
                return cost;
            }
            set
            {
                if(value <= 0)
                {
                    cost = 0;
                }
                else
                {
                    cost = value;
                }
            }
        }

    }
}
