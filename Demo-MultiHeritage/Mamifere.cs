using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MultiHeritage
{
    internal abstract class Mamifere : Animal
    {
        protected Mamifere(string name) : base(name)
        {
        }
    }
}
