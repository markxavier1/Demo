using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Overloading obj = new Overloading();
            int r1 = obj.DoSomeThing(2);
            int r2 = obj.DoSomeThing(2, 4);
            string r3 = obj.DoSomeThing(2, "str");
            string r4 = obj.DoSomeThing("str", 4);
            Console.WriteLine("r1={0}, r2={1}, r3={2}, r4={3}",r1,r2,r3,r4);
            Console.Read();
        }
    }

    public class Overloading
    {

        public int DoSomeThing(int x) // Method with One parameters
        {
            return x;
        }
      
        public int DoSomeThing(int x, int y) // Method with Same Name(No of parameters is Differ)
        {
            return x + y;
        }

        //
        public string DoSomeThing(int x, string y) // Method with Same Name(Type of parameters is Differ)
        {
            return x.ToString() + y;
        }

        public string DoSomeThing(string x, int y) // Method with Same Name(Order of parameters is Differ)
        {
            return x + y.ToString();
        }


    }
}
