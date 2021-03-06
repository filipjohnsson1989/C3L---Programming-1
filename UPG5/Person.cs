using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPG5
{
    class Person
    {
        private string _namn;
        private int _alder;
        private float _langd, _vikt;

        public float Langd { get { return _langd; } }
        public float Vikt { get { return _vikt; } }

        public Person(string namn, int alder, float lengd, float vikt)
        {
            _namn = namn;
            _alder = alder;
            _langd = lengd;
            _vikt = vikt;
        }

        public string PersonInfo()
        {
            return "Personen " + _namn +
                ", personen är " + _alder + "år";
        }
    }
}
