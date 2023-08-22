using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MultiHeritage
{
    internal class Cheval : Mamifere, IHerbivore
    {
        public Cheval(string name) : base(name)
        {
        }
    }
}
