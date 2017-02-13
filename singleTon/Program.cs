using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static System.Console;

namespace singleTon
{

    public delegate void buy();
    public class Stock
    {
        public int Pen;
        public int book;
        private static object _lock = new object();
        private Stock()
        {
            Pen = 5;
            book = 5;
        }
        private static Stock getins = null;
        public static Stock Getins()
        {

            lock (_lock)
            {
                if (getins == null)
                {
                    getins = new Stock();
                }
                return getins;

            }

        }
        public void buyPen()
        {
            Pen = Pen - 1;
            Console.WriteLine("One Pen sold ");
        }
        public void buybook()
        {
            book = book - 1;
            Console.WriteLine("One Book sold " );
        }
    }

    class POS
    {
        public buy pen;
        public buy book;
        public buy combo;
        public POS()
        {
            pen = new buy(aa.buyPen);
            book = new buy(aa.buybook);
            combo = pen + book;
        }


        Stock aa = Stock.Getins();
        public void inStock()
        {
            Console.WriteLine("NOw Stock Left Pen={0}, Book={1}", aa.Pen, aa.book);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            POS p1 = new POS();
            POS p2 = new POS();
            p1.inStock();
            p1.pen();
            p2.inStock();
            p2.combo();
            p1.inStock();

            Console.Read();
        }
    }
}
