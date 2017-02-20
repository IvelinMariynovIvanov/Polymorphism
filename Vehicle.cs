using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
   public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumationPerKm;
        private double tankCapacity;

        public Vehicle(double fuelQuantity, double fuelConsumationPerKm, double tankCapacity)
        {
            this.fuelQuantity = fuelQuantity;
            this.FuelConsumationPerKm = fuelConsumationPerKm;
            this.tankCapacity = tankCapacity;
        }

        public  double FuelQuantity
        {
            get
            {
             return this.fuelQuantity   ;
            }


            set
            {
                if (value < 0)
                    throw new ArgumentException("Fuel must be a positive number");
                fuelQuantity = value;
            }
           
        }

     

        public double TankCapacity
        {
            get
            {
                return tankCapacity;
            }

            set
            {
                if (value > tankCapacity)
                    Console.WriteLine("Cannot fit in tank");
                tankCapacity = value;
            }
        }

        public double FuelConsumationPerKm
        {
            get
            {
                return fuelConsumationPerKm;
            }

            set
            {
                fuelConsumationPerKm = value;
            }
        }

        public abstract void Drive(double distance);

        public abstract void Refuel(double litters);
      

    }
}
