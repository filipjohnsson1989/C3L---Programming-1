using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPG5
{
    class Calculation
    {
        private float _langd, _vikt, _langdIM, _bmi;

        public float LangdIM { get { return _langdIM; } }
        public float BMI { get { return _bmi; } }

        public Calculation(float lengd, float vikt)
        {
            _langd = lengd;
            _vikt = vikt;

            _langdIM = _langd / 100;
            _bmi = _vikt / (_langdIM * _langdIM);
        }

        public string CalculationInfo()
        {
            return $"{_langdIM:0.##}" + "m" + " lång " +
                "och väger " + _vikt + "kg. " +
                "Din beräknade BMI är " + $"{_bmi:0.#}" + ".";
        }


    }
}
