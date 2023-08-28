using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interfaces_Restriction
{
    internal class Personnage : IPersoStat, IPersoAction
    {
        public string Name { get; set; }
        public int For { get; set; }
        public int End { get; set; }
        private int _pv;
        public int PV { 
            get { return _pv; }
            set {
                if (value < 0) value = 0;
                _pv=value;
                if(_pv == 0 ) OnDeath?.Invoke(this);
            }
        }
        public int PVMax { get; set; }

        public bool EstEnVie => PV > 0;

        public event Action<Personnage> OnBeHurt;
        public event Action<Personnage> OnHurt;
        public event Action<Personnage> OnDeath;

        public Personnage(string name)
        {
            Name = name;
            For = 4;
            End = 6;
            PVMax = End * 3;
            PV = PVMax;
        }

        public void Frapper(IPersoAction adversaire) {
            this.OnHurt?.Invoke(this);
            adversaire.SeBlesser(For);
        }

        public void SeBlesser(int degat)
        {
            this.PV -= degat;
            this.OnBeHurt?.Invoke(this);
        }
    }
}
