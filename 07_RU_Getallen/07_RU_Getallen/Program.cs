using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RU_Getallen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rayven Uyttersprot
            // 01/10/2026
            // Project Getallen

            // Velden
            int _getalEen = 0;
            int _getalTwee = 0;
            int _getalDrie = 0;

            // Programma
            try
            {
                // Stap 1: Vraag het eerste getal + opslaan
                Console.Write("Geef me het eerste getal: ");
                _getalEen = int.Parse(Console.ReadLine());
                // Scherm leegmaken
                Console.Clear();

                // Stap 2: Vraag het tweede getal + opslaan
                Console.Write("Geef me het tweede getal: ");
                _getalTwee = int.Parse(Console.ReadLine());
                // Scherm leegmaken
                Console.Clear();

                // Stap 3: Vraag het derde getal + opslaan
                Console.Write("Geef me het derde getal: ");
                _getalDrie = int.Parse(Console.ReadLine());
                // Scherm leegmaken
                Console.Clear();



                // Stap 4: Toon de juiste tekst

            }
            catch
            {

                // Scherm leegmaken



            }
        }
    }
}
