using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_RU_Kleur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rayven Uyttersprot
            // 13/10/2026
            // Project Kleur

            // Velden
            byte _keuze = 0;
            

            // Programma
            try
            {
                //Stap 1: Maak en toon het keuzemenu
                Console.WriteLine("Kies een van de volgende 3 kleuren door het nummer van de kleur in te geven. \n\n 1. rood \n 2. blauw \n 3. groen");

                //Stap 2: Laat de gebruiker een keuze maken +Opslaan
                Console.Write("\nJouw keuze: ");
                _keuze = byte.Parse(Console.ReadLine());

                // Scherm wissen
                Console.Clear();

                //Stap 3: Toon de juiste tekst
                if (_keuze == 1)
                {
                    Console.WriteLine("Je koos rood");
                }
                else if (_keuze == 2)
                {
                    Console.WriteLine("Je koos blauw");
                }
                else if (_keuze == 3)
                {
                    Console.WriteLine("Je koos groen");
                }
                else
                {
                    Console.WriteLine("Dit was geen geldige keuze");
                }
                // Scherm wissen
                Console.WriteLine("\nDruk op enter om af te sluiten");
                Console.ReadKey();
                Console.Clear();
            }
            catch
            {
                // Scherm leegmaken
                Console.Clear();

                // Foutmelding
                Console.WriteLine("U gaf geen juist getal in");
                Console.WriteLine("\nDruk op enter om af te sluiten");
                Console.ReadKey();
                Console.Clear();
            }
            
        }
    }
}
