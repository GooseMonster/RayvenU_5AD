using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RU_GetalOmzetten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rayven Uyttersprot
            // 1/10/2026
            // Project Foutmelding

            // Velden
            int _getal = 0;

            // Programma


            try
            {
                // Stap 1: Vraag een getal + opslaan
                Console.Write("Geef een natuurlijk getal: ");
                _getal = int.Parse(Console.ReadLine());

                // Scherm leegmaken
                Console.Clear();

                // Stap 2: Toon de tekst
                Console.WriteLine("Getal ontvangen. ");
            }
            catch
            {
                // Scherm leegmaken
                Console.Clear();

                // Stap 2: of toon de foutmelding
                Console.WriteLine("Er ging iets fout.");
            }



            }
        }
}
