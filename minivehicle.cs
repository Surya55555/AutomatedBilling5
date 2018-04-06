using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conso
{
    class minivehicle : Vehicle
    {
        public int seatingCapacity;
        public minivehicle(char z, String s, String s1, int a, int b) : base(z, s, s1, a)
        {
            //fuelType
            //vehicleMake
            //vehicleType
            //noOfKiloMeters
            //seatingCapacity
            this.fuelType = z;
            this.vehicleMake = s;
            this.vehicleType = s1;
            this.noOfKiloMeters = a;
            this.seatingCapacity = b;

        }
        public int getSeatingCapacity()
        {
            return seatingCapacity;
        }
        public override void calculateRatePerKiloMeter()
        {
            ratePerKiloMeter = (float)(4.5 + (seatingCapacity - 4) * 1);
        }
        public override double calculateBill()
        {
            int billAmount = (int)(noOfKiloMeters * ratePerKiloMeter);
            return billAmount;
        }

    }
}
