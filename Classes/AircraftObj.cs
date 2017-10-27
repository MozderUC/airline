using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using airline.Interfaces;

namespace airline.Classes
{
    abstract class AircraftObj : IRageData
    {
        // Common aircraft data information
        public string modelName;
        public int manufactureYear;
        public string ID;

        public int aircraftWeight;
        public int fuelReserve;

        // Rage data
        private int averarageRage;
        private int customRage;

        public int AverarageRage
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int CustomRage
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }


        public override string ToString()
        {
            return modelName + " " + ID;
        }

        public virtual int customRageCalculate()
        {
            throw new NotImplementedException();
        }
    }
}
