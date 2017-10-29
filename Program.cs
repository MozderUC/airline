using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using airline.Classes;
namespace airline
{
    class Program
    {
        static void Main(string[] args)
        {
            Airline airline = new Airline();
            Console.WriteLine("Aircraft source data\n"+airline.ShowAircraftList());


            //Sort Aircrafts by Rage
            airline.SortByRage();
            Console.WriteLine("\nSort by Rage\n"+airline.ShowAircraftList());

            //Find plane by fuel consumption
            Console.WriteLine("\nFind aircrafts by fuel consumption\n" + airline.fuelConsumptionSearching(100, 200));

            //Calculate the total cargo capacity
            Console.WriteLine("\nTotal cargo aircrafts capasity:\n"+ airline.totalCargoCapacity());

            //Calculate the total passenger capacity
            Console.WriteLine("\nTotal passenger capasity:\n" + airline.totalPassengerCapacity());

            Console.WriteLine();
        }
    }
}
