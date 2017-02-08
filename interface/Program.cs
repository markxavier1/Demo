using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    class Program
    {
        static void Main(string[] args)
        {

            PatrolVehicle cc = new PatrolVehicle(1, "City", 4, "Honda", true);
            Console.WriteLine(cc.vehicleName());
            Console.WriteLine("Cng:-"+cc.isCNG());

            IVehicle bb = new PatrolVehicle(2, "Apache 150", 2, "TVS", true);
            Console.WriteLine(bb.vehicleName());

            DieselVehicle des = new DieselVehicle(3, "Xyz", 8, "Volvo");
            Console.WriteLine(des.vehicleName());

            IVehicle des2 = new DieselVehicle(4, "Indigo", 4, "TATA");
            Console.WriteLine(des2.vehicleName());
          
            Console.Read();
        }
    }
    public interface IVehicle
    {
        string vehicleName();
    }

    public interface ICng
    {
        bool _cng { get; set; }
        bool isCNG();
    }
    public class PatrolVehicle : IVehicle, ICng
    {
        public PatrolVehicle(int eid,string mo,int tyre, string brand,bool cng)
        {
            EngID = eid;
            Model = mo;
            NoofTyre = tyre;
            vehicleBrand = brand;
            _cng = cng;
        }
        int EngID { get; set; }
        string Model { get; set; }
        int NoofTyre { get; set; }
        string vehicleBrand { get; set; }
        bool cng { get; set; }
        public bool _cng
        {
            get{return cng;}

            set{cng = value;}
        }
        public bool isCNG()
        {
            return _cng;
        }
        public string vehicleName()
        {
            if (NoofTyre <= 2)
            {
                return vehicleBrand + " " + Model + " Patrol Bike ";
            }
            else
            {
                if (NoofTyre <= 4)
                {
                    return vehicleBrand + " " + Model + " Patrol Car ";

                }
                else
                {
                    return vehicleBrand + " " + Model + " Patrol Truck ";

                }
            }
        }
    }
    public class DieselVehicle : IVehicle
    {
        public DieselVehicle(int eid, string mo, int tyre, string brand)
        {
            EngID = eid;
            Model = mo;
            NoofTyre = tyre;
            vehicleBrand = brand;
        
        }
        int EngID { get; set; }
        string Model { get; set; }
        int NoofTyre { get; set; }
        string vehicleBrand { get; set; }
        public string vehicleName()
        {
            if (NoofTyre <= 2)
            {
                return vehicleBrand + " " + Model + " Diesel Bike ";
            }
            else
            {
                if (NoofTyre <= 4)
                {
                    return vehicleBrand + " " + Model + " Diesel Car";
                }
                else
                {
                    return vehicleBrand + " " + Model + " Diesel Truck";
                }
            }
        }
    }
}
