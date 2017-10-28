using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airline.Classes.Aircrafts.PassengerAircrafts
{
    class Boeing_747 : PassengerAircraft
    {
        public Boeing_747() { }
        public Boeing_747(int Year, string ID, int Weight, int fuelRes, int Rage, int humanCap, int cargoCap, string ModelNum, int FuelCons)
            :base(Year,ID,Weight,fuelRes,Rage,ModelNum,humanCap, cargoCap, FuelCons)
        {
        }
        public override int customRageCalculate()
        {
            return base.customRageCalculate();
        }
    }
}
