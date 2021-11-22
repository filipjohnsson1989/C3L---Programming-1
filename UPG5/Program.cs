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
            Input input = new Input();
            input.GetData();

            Person person = new Person(input.Namn, input.Alder, input.Langd, input.Vikt);
            Calculation calculation = new Calculation(input.Langd, input.Vikt);

            Console.WriteLine(person.PersonInfo() + ", " + calculation.CalculationInfo());
            Console.WriteLine("Tryck något att avsluta!");
            Console.ReadLine();
        }
    }
}
