using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            //new employeee
            Employee emp = new Manager(1, "MArk", "Xavier", 200000, true);
            Console.WriteLine("Name :- " + emp.GetName());
            Console.WriteLine("Sal :- " + emp.GetSalary());
            ////////////////


            //new MAnager
            Manager manager = new Manager(2, "Ethan", "manager", 200000, true);
            Console.WriteLine("Name :- " + manager.GetName());
            Console.WriteLine("Sal :- " + manager.GetSalary());
            Console.WriteLine("CArd Login" + manager.GetCardSwip());
            ////////////////

            //new Worker
            Worker worker = new Worker(3, "Anderson", "worker", 120000, 3000);
            Console.WriteLine("Name :- " + worker.GetName());
            Console.WriteLine("Sal :- " + worker.GetSalary());
            ////////////////
            Console.Read();

        }
    }


    public abstract class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AnnualSalary { get; set; }
        public string GetName()
        {
            return this.FirstName + " " + LastName;
        }
        public abstract int GetSalary();
    }


    public class Manager : Employee
    {
        public bool card { get; set; }
        public Manager(int id, string fn, string ln, int sal, bool c)
        {
            base.AnnualSalary = sal; //  use base here
            base.FirstName = fn;    //use this here
            LastName = ln;             //use nothing    --- all work here which one good to use
            this.AnnualSalary = sal;
            card = c;
        }
        public bool GetCardSwip()
        {
            return card;
        }

        public override int GetSalary()
        {
            return this.AnnualSalary / 12;
        }
    }

    public class Worker : Employee
    {
        public int Incentive { get; set; }

        public Worker(int id, string fn, string ln, int sal, int inc)
        {
            base.AnnualSalary = sal;
            base.FirstName = fn;
            LastName = ln;
            this.AnnualSalary = sal;
            Incentive = inc;
        }
        public override int GetSalary()
        {
            return this.AnnualSalary / 12 + Incentive;
        }
    }
}
