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
        public Boeing_747(int Year, string ID, int Weight, int fuelRes, int Rage, int humanCap, int cargoCap)
            :base(Year,ID,Weight,fuelRes,Rage, humanCap, cargoCap)
        {
        }
        public override int customRageCalculate()
        {
            return base.customRageCalculate();
        }
    }
}
