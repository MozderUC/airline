using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using airline.Interfaces;

namespace airline.Classes
{
    abstract class CargoAircraft : AircraftObj, ICargoCapacity
    {
        public int cargoCapacity;

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
