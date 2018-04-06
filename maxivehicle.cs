using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conso
{
    class Maxivehicle : Vehicle
    {
        public float loadInKG { get; set; }
        public float ratePerKG { get; set; }

        public Maxivehicle(char a, String b, String c, int d, int e) : base(a, b, c, d)
        {
            this.fuelType = a;
            this.vehicleMake = b;
            this.vehicleType = c;
            this.noOfKiloMeters = d;
            this.loadInKG = e;
            //  fuelType
            //vehicleMake
            //vehicleType
            //noOfKiloMeters
            //loadInKG


        }

        public bool validateLoadInKG()
        {
            if (loadInKG >= 100 && loadInKG <= 5000)
                return true;
            else
                return false;
        }
        public override void calculateRatePerKiloMeter()
        {
            if (fuelType == 'P')
                ratePerKiloMeter = 6;
            else ratePerKiloMeter = 5;
        }

        public void calculateRatePerKG()
        {
            if (vehicleMake.ToUpper() == "Ashok Leyland".ToUpper())
                ratePerKG = 1.5f;
            else if (vehicleMake.ToUpper() == "Mahindra".ToUpper())
                ratePerKG = 1.0f;
            else
                ratePerKG = 0.5f;
        }
        public override double calculateBill()
        {
            if (!validateLoadInKG())
            {
                Console.WriteLine("Unable to calculate the bill as the entered" + loadInKG + " is incorrect");
                return 0.0;
            }
            else
            {
                double Bill_Amount = noOfKiloMeters * ratePerKiloMeter + loadInKG * ratePerKG;
                return Bill_Amount;
            }

        }

        public float getLoadInKG()
        {
            return loadInKG;
        }
        public float getRatePerKG()
        {
            return ratePerKG;
        }

    }
}
