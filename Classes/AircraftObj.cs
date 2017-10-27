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
        private int manufactureYear;
        private string ID;

        private int aircraftWeight;
        private int fuelReserve;

        // Rage data
        private int averarageRage;
        private int customRage;

        #region Constructor
        public AircraftObj() { }
        public AircraftObj(int Year,string ID, int Weight, int fuelRes, int Rage)
        {
            this.ManufactureYear = Year;
            this.ID1 = ID;
            this.AircraftWeight = Weight;
            this.FuelReserve = fuelRes;
            this.AverarageRage = Rage;
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
        #endregion

        public override string ToString()
        {
            return ID1;
        }

        public virtual int customRageCalculate()
        {
            return this.AverarageRage;            
        }
    }
}
