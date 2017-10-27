using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airline.Classes.Aircrafts.CargoAircrafts
{
    class Boeing_727_100C : CargoAircraft
    {
        public Boeing_727_100C() { }
        public Boeing_727_100C(int Year, string ID, int Weight, int fuelRes, int Rage, int cargoCap)
            :base(Year,ID,Weight,fuelRes,Rage,cargoCap)
        {
        }
        public override int customRageCalculate()
        {
            return base.customRageCalculate();
        }
    }
}
