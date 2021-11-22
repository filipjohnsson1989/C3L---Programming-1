using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPG5
{
    class Menu
    {
        private List<Person> _personList;
        public Menu()
        {
            _personList = new List<Person>();
        }
        public void RunMenu()
        {

            //Att köra samma kodrar som:
            //skirva ut menyn och få användarinmatning till
            //när användare väljer att avsluta programmet.  
            do
            {
                //Anropar av metoden att ut en meny.
                MainMenuText();

                //Anropar av metoder.
                //Anropar den första metoden som heter UserInput att få användarinmatning och returnera den som ett argumant till den andra metoden.
                //Anropar den andra metoden som heter UserChoice att bekräftar användarinmatning och göra den rätta actionen baserat på argumantet.
            } while (UserChoice(UserInput()));
        }
        //Deklarerar metoden  att skriva ut menyns val som olika aktioner.
        private void MainMenuText()
        {
            //Skriver ut det temat(det första argumantet) med specifikt stil(det andra argumantet).
            notification("Gör ditt val:", '*');

            //Skriver ut olika val.
            Console.WriteLine("1: Lägg till en person.");
            Console.WriteLine("2: Visa BMI.");
            Console.WriteLine("3: Avsluta program");
        }

        //Deklarerar metoden  att få användarinmatning och returnera den.
        private int UserInput()
        {
            //Deklarerar en varibel att kanvertera användarinmatning.
            int inputNum;

            //Frågar om användarinmatning.
            string inputString = Console.ReadLine();

            //kanvertera användarinmatning från sträng till heltal.
            Int32.TryParse(inputString, out inputNum);

            //returnera användarinmatning som heltal.
            return inputNum;
        }




        //Deklarerar metoden att skriva ut en text som kommer från den text parametern
        //med en spesifik stil baserat av ett tecken som kommer från den textSign parametern.
        //Att se texten trevlig ut.
        private void notification(string text, char textSign)
        {
            //Deklarera och spår värden för längd av före eller efter tecken som jag tror 5 är nog.
            int pTextSignLength = 5;

            //Deklarera och spår värden som kommer från skapa en text
            //baserat av ett tecken som är det textSign argumantet som kommer från den textSign parametern
            //och repetera längden gånger som är den pTextSignLength varibeln
            //i den erroSignRepeated varibeln
            string erroSignRepeated = new string(textSign, pTextSignLength);

            //Deklarera och spår värden som är
            //längd av tecken multiplicerat med två för att komma före och efter texten
            //plus den längden av den text parametern
            //i den breakLineLength varibeln.
            int breakLineLength = text.Length + pTextSignLength * 2;


            //Anropar av metoden att
            //bryta texten i konsolen med
            //tecken som är den textSign parametern
            //med längden som är breakLineLength varibeln.
            //Skriver ut den första linjen som är bara tecken.
            //samma som tredje linjen här.
            BreakLine(textSign, breakLineLength);

            //andrade texten till 
            //före tecken som är den erroSignRepeated varibeln
            //och den texten som är den text parametern
            //och efter tecken som är den erroSignRepeated varibeln.
            text = erroSignRepeated + text + erroSignRepeated;

            //Skriver ut den andrade texten som är den text parametern
            //som den andra linjen
            Console.WriteLine(text);

            //Anropar av metoden att
            //bryta texten i konsolen med
            //tecken som är den textSign parametern
            //med längden som är breakLineLength varibeln.
            //Skriver ut den tredje linjen
            //samma som första linjen här.
            BreakLine(textSign, breakLineLength);
        }


        //Deklarerar metoden att skriva ut en bryta text
        //Första line är tom
        //Andra line är det '-' tecken som är upprepat standard gånger
        //Tredje line är tom
        private void BreakLine()
        {
            //skriv ut en tom linje
            Console.WriteLine();


            //Anropar av metoden att
            //bryta ut i konsolen med
            //det '-' tecken som är upprepat standard gånger
            //tecken går som en argumant
            BreakLine('-');

            //skriv ut en tom linje
            Console.WriteLine();
        }


        //Deklarerar metoden att skriva ut en bryta text
        //den breakLineType parametern är täcken som upprepat samma gånger som är den length parametern
        //standard upprepat är 50 gånger
        private void BreakLine(char breakLineType, int length = 50)
        {
            //Deklarera och spår värden som kommer från skapa en text
            //baserat av ett tecken som är det breakLineType argumantet som kommer från den breakLineType parametern
            //och repetera längden gånger som är det length argumantet som kommer från den length parametern
            //i den breakline varibeln.
            string breakline = new string(breakLineType, length);

            //Skriver ut den bryta texten som är den breakline varibeln
            Console.WriteLine(breakline);
        }

        //Deklarerar metoden att bekräfta användarinmatning som kommer från den userInput parametern
        //och göra den rätta actionen baserat på användarinmatning. 
        private bool UserChoice(int userInput)
        {
            //Deklarerar en variabel som vi behöver användas oss att hantera fortlöpande programmet.
            bool programContinue = true;

            //Gör den rätta actionen baserat på användarinmatning mellan olika val.
            switch (userInput)
            {
                //Om parameteren är ett, bekräftar det först sen lägger till en person.
                case 1:
                    //Anropar av metoden att bekräfta användarinmatningen(det första argumantet) i fetstilta(det andra argumantet) .
                    notification("Du har gjort Val1 att lägga till en person.", '#');

                    //Anropar av metoder att lägga till en person.
                    //Att lägga till en person
                    Input input = new Input();
                    input.GetData();

                    Person person = new Person(input.Namn, input.Alder, input.Langd, input.Vikt);
                    _personList.Add(person);

                    //Förhindra att kontrollera av resten som är obligatorisk i Switch case satsen i synatxen.
                    break;

                //Om parameteren är två, bekräftar det först sen visar BMI.
                case 2:
                    //Anropar av metoden att bekräfta användarinmatningen(det första argumantet) i fetstilta(det andra argumantet).
                    notification("Du har gjort Val2 att visa BMI.", '#');

                    //Anropar av metoder att visa BMI.
                    //Att visa BMI
                    foreach (var personIndex in _personList)
                    {
                        Calculation calculation = new Calculation(personIndex.Langd, personIndex.Vikt);

                        Console.WriteLine(personIndex.PersonInfo() + ", " + calculation.CalculationInfo());
                    }

                    //Förhindra att kontrollera av resten som är obligatorisk i Switch case satsen i synatxen.
                    break;

                //Om parameteren är tre, informerar det först programmet avslutas sen byter den global varibeln att avslutar.
                case 3:
                    //Anropar av metoden att informera men texten(det första argumantet) med specifikt stil(det andra argumantet).
                    notification("Programmet avslutas.", '-');

                    //Byter den global varibeln att avslutar.
                    programContinue = false;

                    //Förhindra att kontrollera av resten som är obligatorisk i Switch case satsen i synatxen.
                    break;

                //Om parameteren är något annat, varnar den och låter prova igen.
                default:
                    //Anropar av metoden att varna.
                    notification("Ditt val är ej giltig, prova igen.", '!');

                    //Förhindra att kontrollera av resten som är obligatorisk i Switch case satsen i synatxen.
                    break;
            }

            //Anropar av metoden att
            //bryta texten i konsolen med me en specefik stil i tre linjer.
            BreakLine();
            return programContinue;
        }
    }
}
