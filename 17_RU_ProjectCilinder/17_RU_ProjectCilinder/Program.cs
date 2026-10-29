using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _17_RU_ProjectCilinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rayven Uyttersprot
            // 29/10/2026
            // Project Cilinder

            // Velden
            Byte _keuze = 0;
            double _grondvlak = 0;
            double _hoogte = 0;

            // Programma
            do
            {
                // Stap 1: Toon de gebruiker een keuzemenu voor 1) berekenen van inhoud en omtrek van een cilinder. 2) Afsluiten
                Console.WriteLine("Maak een keuze uit onderstaand menu: \n 1) Berekenen van de inhoud en omtrek van een cilinder \n 2) Afsluiten");
                _keuze = Byte.Parse(Console.ReadLine());

                // Scherm Wissen
                Console.Clear();

                try
                {
                    // Stap 2: 
                    // Als keuze 1: vraag de gebruiker om een straal van het grondvlak van de cilinder en de hoogte van een cilinder
                    if (_keuze == 1)
                    {
                        Console.Write("Geef de straal van het grondvlak van de cilinder in centimeter: ");
                        _grondvlak = double.Parse(Console.ReadLine());
                        
                        Console.Write("Geef de hoogte van de cilinder in centimeter: ");
                        _hoogte = double.Parse(Console.ReadLine());
                    }

                    // Stap 3: Bereken en toon de uitkomst van de cilinder

                    // Stap 4: Zolang keuze niet 2 is, ga terug naar stap 1
                }
                catch
                {
                    // Scherm Wissen
                    Console.Clear();

                    Console.WriteLine("Je hebt iets fout ingegeven.");
                }
            }
            while (_keuze != 2);


        }
    }
}
