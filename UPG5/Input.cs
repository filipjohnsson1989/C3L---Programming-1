using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPG5
{
    class Input
    {
        private string _namn;
        private int _alder;
        private float _langd, _vikt;

        public string Namn { get { return _namn; } }
        public int Alder { get { return _alder; } }
        public float Langd { get { return _langd; } }
        public float Vikt { get { return _vikt; } }

        public void GetData()
        {
            Console.WriteLine("Hej! Vad heter du?");
            _namn = Console.ReadLine();
            Console.WriteLine("Hur gammal är du?");
            Int32.TryParse(Console.ReadLine(), out _alder);
            Console.WriteLine("Hur lång är du i cm?");
            _langd = float.Parse(Console.ReadLine());
            Console.WriteLine("Hur mycket väger du i kg?");
            _vikt = float.Parse(Console.ReadLine());
        }
    }
}
