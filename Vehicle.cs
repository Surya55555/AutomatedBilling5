using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conso
{
    public abstract class Vehicle
    {
        public int billID { get; set; }
        public char fuelType { get; set; }
        public string vehicleMake { get; set; }
        public string vehicleType { get; set; }
        public int noOfKiloMeters { get; set; }
        public float ratePerKiloMeter { get; set; }
        public static int counter { get; set; }
        public Vehicle(char charvar, String strvar, String strvar2, int intvar)
        {

        }
        public int getBillID()
        {
            Random rnd = new Random();
            billID = rnd.Next(1001);
            return billID;
        }
        public char getFuelType()
        {

            return fuelType;
        }
        public string getVehicleMake() { return vehicleMake; }
        public string getVehicleType() { return vehicleType; }
        public int getNoOfKiloMeters() { return noOfKiloMeters; }
        public float getRatePerKiloMeter() { return ratePerKiloMeter; }
        public void validateFuelType()
        {
            if (fuelType == 'P' || fuelType == 'D')
            {

            }
            else
            {
                fuelType = 'D';
                Console.WriteLine("Invalid fueltype set value to 'D'.");
            }
        }
        public abstract void calculateRatePerKiloMeter();
        public abstract double calculateBill();

    }
}
