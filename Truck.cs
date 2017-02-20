using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
   public class Truck:Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumationPerKm, double tankCapacity)
            :base(fuelQuantity, fuelConsumationPerKm, tankCapacity)
        {
            
        }

        public override void Drive( double distance)
        {
            if (distance < this.FuelQuantity / (FuelConsumationPerKm + 1.6))
            {
                if(FuelQuantity > distance * ((double)FuelConsumationPerKm + 1.6))
                {
                    double result = distance * ((double)FuelConsumationPerKm + 1.6);
                    FuelQuantity -= (int)result;
                    Console.WriteLine($"Truck travelled {distance} km");
                }

                else
                    Console.WriteLine("Fuel must be a positive number");
                 
            }
            else
            {
                Console.WriteLine("Truck needs refueling"); ;
            }
        }

        public override void Refuel(double litters)
        {

            {
                FuelQuantity += litters *0.95;
            }

        }
    }
}
