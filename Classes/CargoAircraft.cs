﻿using System;
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


        public CargoAircraft() { }
        public CargoAircraft(int Year, string ID, int Weight, int fuelRes, int Rage, int cargoCapacity)
            :base(Year,ID,Weight,fuelRes,Rage)
        {
            this.CargoCapacity = cargoCapacity;
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
