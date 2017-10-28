using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airline.Classes.Aircrafts.CargoAircrafts
{
    class An_124_100 : CargoAircraft
    {
        public An_124_100() { }
        public An_124_100(int Year, string ID, int Weight, int fuelRes, int Rage, int cargoCap, string ModelNam, int FuelCons)
            :base(Year,ID,Weight,fuelRes,Rage,ModelNam,cargoCap, FuelCons)
        {            
        }
        public override int customRageCalculate()
        {
            return base.customRageCalculate();
        }
    }
}
