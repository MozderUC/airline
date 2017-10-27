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
    }
}
