using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using airline.Interfaces;

namespace airline.Classes
{
    class Airline
    {
        private List<AircraftObj> listAircraft = new List<AircraftObj>();
        private airlineParser airlinePars = new airlineParser();


        #region Constructor
        public Airline()
        {
            listAircraft = airlinePars.parse();
        }
        #endregion


        #region Methods
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

        public int totalCargoCapacity()
        {
            int totalCargo=0;
            foreach (AircraftObj el in listAircraft)
            {
                ICargoCapacity cargoObj = el as ICargoCapacity;
                if (cargoObj != null)
                {
                    totalCargo += cargoObj.CargoCapacity;
                }
            }
            return totalCargo;
        }

        public int totalPassengerCapacity()
        {
            int totalPassnger = 0;
            foreach (AircraftObj el in listAircraft)
            {
                IHumanCapacity cargoObj = el as IHumanCapacity;
                if (cargoObj != null)
                {
                    totalPassnger += cargoObj.HumanCapacity;
                }
            }
            return totalPassnger;
        }
        #endregion
    }
}
