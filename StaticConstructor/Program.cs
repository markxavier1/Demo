using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Exam e = new Exam(58, 56, 85);
            Console.WriteLine(e.getTotal());
            Console.Read();
        }
    }
    class Exam
    {
        public int Eng { get; set; }
        public int Hindi { get; set; }
        public int Math { get; set; }
        public static int Min { get; set; }
        public static int Max { get; set; }
        public int Total { get; set; }
        static Exam() //this call only once during class load.
        {
            Max = 100;
            Min = 35;
            Console.WriteLine("Max Mark of each subject {0} and Required Minimum Marks {1} in each Subject ", Max, Min);
        }
        public Exam(int _eng, int _hin, int _math)
        {
            Eng = _eng;
            Hindi = _hin;
            Math = _math;
        }
        public string getTotal()
        {
            Total = Eng + Hindi + Math;
            if (Eng <= Min || Hindi <= Min || Math <= Min)
            {
                return "Fail with " + Total.ToString() + " MArks";
            }
            else
            {
                return "Pass with " + Total.ToString() + " MArks";
            }
        }
    }
}
