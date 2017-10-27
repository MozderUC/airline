using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airline.Classes
{
    abstract class AircraftObj
    {
        // Common aircraft data information
        private string modelName;
        private int manufactureYear;
        private string ID;

        private int aircraftWeight;
        private int maxRange;
        private int fuelReserve;


        #region Properties
        public string ModelName
        {
            get
            {
                return modelName;
            }

            set
            {
                modelName = value;
            }
        }

        public int ManufactureYear
        {
            get
            {
                return manufactureYear;
            }

            set
            {
                manufactureYear = value;
            }
        }

        public string ID1
        {
            get
            {
                return ID;
            }

            set
            {
                ID = value;
            }
        }

        public int AircraftWeight
        {
            get
            {
                return aircraftWeight;
            }

            set
            {
                aircraftWeight = value;
            }
        }

        public int MaxRange
        {
            get
            {
                return maxRange;
            }

            set
            {
                maxRange = value;
            }
        }

        public int FuelReserve
        {
            get
            {
                return fuelReserve;
            }

            set
            {
                fuelReserve = value;
            }
        }
        #endregion

        #region Constructors
        public AircraftObj() { }

        public AircraftObj(string modelName, int aircraftWeight, int maxRange, string ID, int fuelReserve)
        {
            this.ModelName = modelName;
            this.AircraftWeight = aircraftWeight;
            this.MaxRange = maxRange;
            this.ID1 = ID;
            this.FuelReserve = fuelReserve;
        }
        #endregion

        public virtual void rageCalculate()
        { }


    }
}
