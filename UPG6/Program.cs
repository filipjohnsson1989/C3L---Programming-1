using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPG6
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            bool addNewLine;

            Console.WriteLine(
                    @"Hej!
Skriv in texten som ska läggas till i filen, annars tryck på Enter för att avsluta!"
                );


            do
            {
                input = Console.ReadLine();
                addNewLine = !string.IsNullOrEmpty(input);
                if (addNewLine)
                    FileManager.Update(TextManager.InputFormat(input));
            } while (addNewLine);

            Console.WriteLine("Läsa och skriva filen i storbostäver");
            Console.WriteLine(TextManager.OutputFormat(FileManager.Read()));
        }
    }
}
