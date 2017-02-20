using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
   public class Car:Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumationPerKm, double tankCapacity)
            :base(fuelQuantity, fuelConsumationPerKm, tankCapacity)
        {
            
        }

        public override void Drive(double distance)
        {
            if (distance < this.FuelQuantity / (FuelConsumationPerKm + 0.9))
            {
                if (FuelQuantity > distance * (FuelConsumationPerKm + 0.9))
                {
                    double result = distance * ((double)FuelConsumationPerKm + 0.9);
                    FuelQuantity -= (int)result;
                    Console.WriteLine($"Car travelled {distance} km");
                }
                
                else
                    Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                 Console.WriteLine("Car needs refueling"); ;
            }
            
        }

        public override void Refuel(double litters)
        {
            if (this.TankCapacity >= this.FuelQuantity + litters)
            {
                this.FuelQuantity += litters;
            }

            else
                Console.WriteLine("Cannot fit fuel in tank");
            
        }
    }
}
