using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Event
{
    internal class Poisson
    {
        private int _pv;
        public int Pv { 
            get { return _pv;}
            private set { 
                _pv = value;
                if(_pv <= 0) OnDeath?.Invoke(this);
            }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public bool EstEnVie { get { return Pv > 0; } }

        public event Action<Poisson> OnDeath;
        public Poisson(string name)
        {
            Name = name;
            Pv = 10;
        }

        public void Vieillir()
        {
            Pv--;
        }

    }
}
