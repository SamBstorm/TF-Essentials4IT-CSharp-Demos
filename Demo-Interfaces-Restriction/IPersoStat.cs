using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interfaces_Restriction
{
    internal interface IPersoStat
    {
        string Name { get; }
        int For { get; }
        int End { get; }
        int PV { get; }
        int PVMax { get; }
        bool EstEnVie { get; }
    }
}
