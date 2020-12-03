using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Item item = new Item();
            item.Price = 0;

            item.PriceChanged += ShowPriceChangedMessage;

            item.Price = 10;

            Console.Read();
        }

        private static void ShowPriceChangedMessage(int val)
        {
            Console.WriteLine("Price of item changed to {0}", val);
        }
    }

    class Item
    {
        private string name { get; set; }
        private int price;

        public delegate void PriceChangedEventHandler(int val);
        public event PriceChangedEventHandler PriceChanged;

        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
                if (PriceChanged != null)
                {
                    PriceChanged(value);
                }
            }

        }
    }
}
