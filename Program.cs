using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conso
{
    class Demo
    {
        public static minivehicle getInitializeObjMini(String s2)
        {
            minivehicle obj = new minivehicle('P', "Mazda", s2, 40, 7);
            obj.calculateRatePerKiloMeter();
            obj.validateFuelType();
            obj.calculateBill();
            Console.WriteLine(" " + obj.vehicleType + " " + obj.billID + " " + obj.ratePerKiloMeter + " " + obj.fuelType + " " + obj.seatingCapacity);

            //        Vehicle Type      
            //            BillID               
            //        Rate per Kilo Meter
            //       Fuel type
            //Seating Capacity

            return obj;
        }
        public static Maxivehicle getInitializeObjMaxi(String s1)
        {
            Maxivehicle obj = new Maxivehicle('D', "Tata", s1, 200, 1500);
            obj.calculateRatePerKiloMeter();
            obj.validateFuelType();
            obj.calculateRatePerKG();
            obj.calculateBill();
            Console.WriteLine(" " + obj.vehicleType + " " + obj.billID + " " + obj.ratePerKiloMeter + " " + obj.fuelType + " " + obj.loadInKG + " " + obj.ratePerKG + " ");

            //Vehicle Type       
            // BillID                
            //Rate per Kilo Mete
            //Fuel type
            //Seating Capacity

            return obj;
        }
        public static void Main(String[] args)
        {

            getInitializeObjMaxi("max");
            getInitializeObjMini("min");
            Console.ReadKey();
        }
    }
}

