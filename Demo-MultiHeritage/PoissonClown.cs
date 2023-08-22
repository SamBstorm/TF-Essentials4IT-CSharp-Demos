using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MultiHeritage
{
    internal class PoissonClown : Poisson, ICarnivore
    {
        public PoissonClown(string name) : base(name)
        {
        }
    }
}
