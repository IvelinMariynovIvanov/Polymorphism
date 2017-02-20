using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Bus:Vehicle
    {
      

        public Bus(double fuelQuantity, double fuelConsumationPerKm, double tankCapacity)
            :base(fuelQuantity, fuelConsumationPerKm, tankCapacity)
        {
           
        }

      

        public override void Drive(double distance)
        {
    
                if (distance < this.FuelQuantity / (FuelConsumationPerKm + 1.4))
                {
                    if (FuelQuantity > distance * ((double)FuelConsumationPerKm + 1.4))
                    {
                        double result = distance * ((double)FuelConsumationPerKm + 1.4);
                        FuelQuantity -= (int)result;

                        Console.WriteLine($"Bus travelled {distance} km");
                    }

                    else
                        Console.WriteLine("Fuel must be a positive number");

                }
                else
                {
                    Console.WriteLine("Truck needs refueling"); ;
                }
        }

        public void DriveEmptyBus(double distance)
        {
            if (distance < this.FuelQuantity / (FuelConsumationPerKm ))
            {
                
                    double result = distance * ((double)FuelConsumationPerKm);
                    FuelQuantity -= (int)result;
                    Console.WriteLine($"Bus travelled {distance} km");
              

              //  else
                   // Console.WriteLine("Fuel must be a positive number");

            }
            else
            {
                Console.WriteLine("Bus needs refueling"); ;
            }
        }

        public override void Refuel(double litters)
        {
            if (this.TankCapacity >= this.FuelQuantity + litters)
            {
                FuelQuantity += litters;
            }

            else
                Console.WriteLine("Cannot fit fuel in tank");

        }
    }
}
