using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPG5
{
    class Program
    {
        static void Main(string[] args)
        {
            string namn;
            int alder;
            float langd, vikt;

            Console.WriteLine("Hej! Vad heter du?");
            namn = Console.ReadLine();
            Console.WriteLine("Hur gammal är du?");
            Int32.TryParse(Console.ReadLine(), out alder);
            Console.WriteLine("Hur lång är du i cm?");
            langd = float.Parse(Console.ReadLine());
            Console.WriteLine("Hur mycket väger du i kg?");
            vikt = float.Parse(Console.ReadLine());

            Person person = new Person(namn, alder);
            Calculation calculation = new Calculation(langd, vikt);

            Console.WriteLine(person.PersonInfo() + ", " + calculation.CalculationInfo());
            Console.WriteLine("Tryck något att avsluta!");
            Console.ReadLine();
        }
    }
}
