using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _15_RU_MeerDob
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rayven Uyttersprot
            // 20/10/2026
            // Project MeerDobbelstenen

            // Velden
            Random _rdm1 = new Random();
            Byte _aantalOgen = 0;
            Byte _keuze = 0;

            // Programma
            do
            {
                // Scherm wissen
                Console.Clear();

                Console.WriteLine("Maak uw keuze uit onderstaand menu:");

                // Stap 1a: Toon eerste deel keuzemenu(ogen)
                Console.WriteLine("\n   1) Geef het aantal ogen van de dobbelsteen in");

                // Stap 2: kijk of het aantal ogen is ingegeven
                // als ja:
                if (_aantalOgen != 0)
                {
                    // Stap 3: toon de rest van het keuzemenu(werpen, resetten)
                    Console.WriteLine("   2) Werp de dobbelsteen \n   3) Reset het totaal");
                }


                // Stap 1b: Toon eerste deel keuzemenu(afsluiten)
                Console.WriteLine("   4) afsluiten");

                try
                {

                    // Stap 4: vraag keuze +opslaan
                    Console.Write("\nGeef uw keuze: ");
                    _keuze = Byte.Parse(Console.ReadLine());

                    // Scherm wissen
                    Console.Clear();


                    // Als 1:
                    if (_keuze == 1)
                    {
                        // Stap 5: vraag hoeveel ogen de dobbelsteen heeft +opslaan
                        Console.Write("Geef het aantal ogen dat u voor de dobbelsteen wilt: ");
                        _aantalOgen = byte.Parse(Console.ReadLine());                    
                    }
                    // Als 2:
                    else if (_keuze == 2)
                    {
                        // Stap 6: Toon de worp van de dobbelsteen +opslaan

                        // Stap 7: Toon het totaal van alle worpen samen
                    }
                    // Als 3:
                    if (_keuze == 3)
                    {
                        
                        // Stap 8: reset het resultaat
                    }
                    // Als 4:
                    else if (_keuze == 4)
                    {
                        
                        // Stap 9: Toon afsluittekst
                    }
                    
                }
                catch
                {
                    // Scherm wissen
                    Console.Clear();

                    // foutmelding
                    Console.WriteLine("U gaf geen getal in.");
                    Console.WriteLine("Druk op enter om naar het hoofdmenu te gaan");
                    Console.ReadKey();
                }
            }
            // Stap 10: Indien keuze niet 4 is, ga naar stap 1
            while (_keuze != 4);
            
        }
    }
}
