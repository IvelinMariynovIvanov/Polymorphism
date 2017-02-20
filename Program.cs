using Polymorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            string car = Console.ReadLine();
            string[] carInfo = car.Split(' ').ToArray();
            Car currentcar = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));
            string truck = Console.ReadLine();
            string[] truckInfo = truck.Split(' ').ToArray();
            Truck currentTruck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]),double.Parse(truckInfo[3]));
            string bus = Console.ReadLine();
            string[] busInfo = bus.Split(' ').ToArray();
            Bus currentBus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string command = Console.ReadLine();
                string[] commandInfo = command.Split(' ').ToArray();
                if(commandInfo[1] == "Car")
                {
                    if (commandInfo[0] == "Drive")
                        currentcar.Drive(double.Parse(commandInfo[2]));
                    else
                        currentcar.Refuel(double.Parse(commandInfo[2]));
                }

                else if(commandInfo[1] == "Truck")
                {
                    if (commandInfo[0] == "Drive")
                        currentTruck.Drive(double.Parse(commandInfo[2]));
                    else
                        currentTruck.Refuel(double.Parse(commandInfo[2]));
                }

                else if(commandInfo[1] == "Bus")
                {
                    if (commandInfo[0] == "Drive")
                        currentBus.Drive(double.Parse(commandInfo[2]));
                    else if (commandInfo[0] == "DriveEmpty")
                        currentBus.DriveEmptyBus(double.Parse(commandInfo[2]));
                    else
                        currentBus.Refuel(double.Parse(commandInfo[2]));
                }
            }

            Console.WriteLine();
            Console.WriteLine("{0:f2}", currentcar.FuelQuantity);
            Console.WriteLine("{0:f2}",currentTruck.FuelQuantity);
            Console.WriteLine("{0:f2}", currentBus.FuelQuantity);

        }
    }
}
