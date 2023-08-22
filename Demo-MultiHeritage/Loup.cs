using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MultiHeritage
{
    internal class Loup : Mamifere, ICarnivore
    {
        public Loup(string name) : base(name)
        {
        }
    }
}
