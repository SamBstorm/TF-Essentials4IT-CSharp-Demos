using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MultiHeritage
{
    internal class PoissonCarnivore : Poisson
    {
        public PoissonCarnivore(string name) : base(name)
        {
        }
    }
}
