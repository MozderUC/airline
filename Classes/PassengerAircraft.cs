using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using airline.Interfaces;

namespace airline.Classes
{
    abstract class PassengerAircraft : AircraftObj, IHumanCapacity, ICargoCapacity
    {
        private int humanCapacity;
        private int cargoCapacity;

        public PassengerAircraft() { }
        public PassengerAircraft(int Year, string ID, int Weight, int fuelRes, int Rage, string ModelNam, int humanCapa, int cargoCapa, int FuelCons)
            :base(Year,ID,Weight,fuelRes,Rage,ModelNam, FuelCons)
        {
            this.HumanCapacity = humanCapa;
            this.CargoCapacity = cargoCapa;
        }

        public int HumanCapacity
        {
            get
            {
                return humanCapacity;
            }

            set
            {
                this.humanCapacity = value;
            }
        }
        public int CargoCapacity
        {
            get
            {
                return cargoCapacity;
            }

            set
            {
                this.cargoCapacity = value;
            }
        }
    }
}
