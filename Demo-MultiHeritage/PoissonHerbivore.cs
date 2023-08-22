using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MultiHeritage
{
    internal class PoissonHerbivore : Poisson
    {
        public PoissonHerbivore(string name) : base(name)
        {
        }
    }
}
