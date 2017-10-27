using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airline.Classes.Aircrafts.PassengerAircrafts
{
    class An_2 : PassengerAircraft
    {
        public An_2() { }
        public An_2(int Year, string ID, int Weight, int fuelRes, int Rage, int humanCap, int cargoCap)
            :base(Year,ID,Weight,fuelRes,Rage, humanCap, cargoCap)
        {
        }
        public override int customRageCalculate()
        {
            return base.customRageCalculate();
        }
    }
}
