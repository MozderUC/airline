using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airline.Interfaces
{
    interface IRageData
    {
        int AverarageRage { get; set; }
        int CustomRage { get; set; }

        int customRageCalculate();

    }
}
