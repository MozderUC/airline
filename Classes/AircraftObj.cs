using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using airline.Interfaces;

namespace airline.Classes
{
    abstract class AircraftObj : IRageData, IComparable<AircraftObj>
    {
        // Common aircraft data information
        private string modelName;
        private int manufactureYear;
        private string ID;

        private int aircraftWeight;
        private int fuelReserve;
        private int fuelConsumption;

        // Rage data
        private int averarageRage;
        private int customRage;

        #region Constructor
        public AircraftObj() { }
        public AircraftObj(int Year,string ID, int Weight, int fuelRes, int Rage, string ModelNa, int FuelCons)
        {
            this.ManufactureYear = Year;
            this.ID1 = ID;
            this.AircraftWeight = Weight;
            this.FuelReserve = fuelRes;
            this.AverarageRage = Rage;
            this.ModelName = ModelNa;
            this.FuelConsumption = FuelCons;
        }
        #endregion

        #region Props
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

        public int AverarageRage
        {
            get
            {
                return averarageRage;
            }

            set
            {
                averarageRage = value;
            }
        }

        public int CustomRage
        {
            get
            {
                return customRage;
            }

            set
            {
                customRage = value;
            }
        }

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

        public int FuelConsumption
        {
            get
            {
                return fuelConsumption;
            }

            set
            {
                fuelConsumption = value;
            }
        }
        #endregion

        public override string ToString()
        {
            return String.Format("Model:{0}\tFuelConsumption:{1}\tRage:{2}\n",
                this.ModelName, this.FuelConsumption, this.AverarageRage);
        }

        public virtual int customRageCalculate()
        {
            return this.AverarageRage;            
        }

        public int CompareTo(AircraftObj other)
        {
            if (this.averarageRage > other.averarageRage)
                return 1;
            if (this.averarageRage < other.averarageRage)
                return -1;
            else
                return 0;
        }
    }
}
