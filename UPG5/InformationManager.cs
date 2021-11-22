using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPG5
{
    class InformationManager
    {
        private List<Person> _personList;
        public InformationManager()
        {
            _personList = new List<Person>();
        }

        public void AddNewPerson(string namn, int alder, float langd, float vikt)
        {
            Person person = new Person(namn, alder, langd, vikt);
            _personList.Add(person);
        }

        public void InformationManagerInfo()
        {
            foreach (var personIndex in _personList)
            {
                Calculation calculation = new Calculation(personIndex.Langd, personIndex.Vikt);

                Console.WriteLine(personIndex.PersonInfo() + ", " + calculation.CalculationInfo());
            }
        }
    }
}
