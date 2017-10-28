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

            airline.SortByRage();
            Console.WriteLine("\nSort by Rage\n"+airline.ShowAircraftList());


            Console.WriteLine("\nFind aircrafts by fuel consumption\n" + airline.fuelConsumptionSearching(100, 200));


            Console.WriteLine();
        }
    }
}
