using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interfaces_Restriction
{
    internal interface IPersoAction
    {
        bool EstEnVie { get; }
        void Frapper(IPersoAction adversaire);

        void SeBlesser(int degat);
    }
}
