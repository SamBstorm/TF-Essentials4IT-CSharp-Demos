using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MultiHeritage
{
    internal abstract class Poisson : Animal
    {
        protected Poisson(string name) : base(name)
        {
        }
    }
}
