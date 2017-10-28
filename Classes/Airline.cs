using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airline.Classes
{
    class Airline
    {
        public List<AircraftObj> listAircraft = new List<AircraftObj>();
        private airlineParser airlinePars = new airlineParser();

        public Airline()
        {
            listAircraft = airlinePars.parse();
        }

        public string ShowAircraftList()
        {
            string buff="";
            foreach(AircraftObj el in listAircraft)
            {
                //buff += el.ToString;
                buff = buff + el.ToString();
            }
            return buff;          
        }

        public void SortByRage()
        {
            listAircraft.Sort();
        }

        public string fuelConsumptionSearching(int min, int max)
        {
            string buff="";
            foreach(AircraftObj el in listAircraft)
            {
                if (el.FuelConsumption > min && el.FuelConsumption < max)
                    buff = buff + el.ToString();
            }
            return buff;
        }



    }
}
