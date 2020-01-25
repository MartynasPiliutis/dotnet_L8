using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirkinysStruct
{
    public struct Pirkinys
    {
        private string _pavadinimas;
        private int _kiekis;
        private double _kaina;

        public string PrekesPavadinimas
        {
            get { return _pavadinimas; }
            set { _pavadinimas = value; }
        }

        public int PrekesKiekis
        {
            get { return _kiekis; }
            set { _kiekis = value; }
        }

        public double PrekesKaina
        {
            get { return _kaina; }
            set { _kaina = value; }
        }

        public double KainaViso
        {
            get { return _kiekis * _kaina;  }
            private set { }
        }
    }
}
