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

        public Person(string name, int alder)
        {
            _namn = name;
            _alder = alder;
        }

        public string PersonInfo()
        {
            return "Hej " + _namn +
                ", du är " + _alder + "år";
        }
    }
}
