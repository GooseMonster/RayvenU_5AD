using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_RU_Randoms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rayven Uyttersprot
            // 20/10/2026
            // Project Randoms 

            // Velden
            Byte _Keuze = 0;
            Random _rdm1 = new Random();
            Random _rdm2 = new Random();
            int _Getal1 = -1;
            int _Getal2 = -1;

            // Programma
            do
            {
                // Scherm Wissen
                Console.Clear();


                // toon keuzemenu
                Console.WriteLine("Maak uw keuze van het menu.");
                Console.WriteLine(" 1) maak 2 randoms zonder voorwaarde");
                Console.WriteLine(" 2) Maak 2 verschillende willekeurige getallen");
                Console.WriteLine(" 3) Maak 2 verschillende willekeurige getallen met max-waarde");
                Console.WriteLine(" 4) Maak 2 verschillende willekeurige getallen met max-waarde en min-waarde");
                Console.WriteLine("5) Afsluiten");
                try
                {
                    // vraag de keuze + opslaan
                    Console.Write("\nUw keuze geven:");
                    _Keuze = Byte.Parse(Console.ReadLine());

                    //als 1
                    if (_Keuze == 1)
                    {
                        // Maak 2 willekeurige getallen
                        _Getal1 = _rdm1.Next();
                        _Getal2 = _rdm2.Next();

                        // Toon ze op het scherm

                        Console.WriteLine($"De twee getallen zijn {_Getal1.ToString()} en {_Getal2.ToString()}");
                        Console.WriteLine("Druk op enter om verder te gaan.");
                        Console.ReadKey();
                    }
                    //als 2
                    else if (_Keuze == 2)
                    {
                        _Getal1 = _rdm1.Next();
                        _Getal2 = _rdm2.Next();

                        // Toon ze op het scherm
                        Console.WriteLine($"De twee getallen zijn {_Getal1.ToString()} en {_Getal2.ToString()}");
                        Console.WriteLine("Druk op enter om verder te gaan.");
                        Console.ReadKey();
                    }
                    //als 3
                    else if (_Keuze == 3)
                    {
                        _Getal1 = _rdm1.Next(10);
                        _Getal2 = _rdm1.Next(10);

                        // Toon ze op het scherm
                        Console.WriteLine($"De twee getallen zijn {_Getal1.ToString()} en {_Getal2.ToString()}");
                        Console.WriteLine("Druk op enter om verder te gaan.");
                        Console.ReadKey();
                    }
                    //als 4
                    else if (_Keuze == 4)
                    {
                        _Getal1 = _rdm1.Next(10, 100);
                        _Getal2 = _rdm1.Next(10, 100);

                        // Toon ze op het scherm
                        Console.WriteLine($"De twee getallen zijn {_Getal1.ToString()} en {_Getal2.ToString()}");
                        Console.WriteLine("Druk op enter om verder te gaan.");
                        Console.ReadKey();
                    }
                    //als 5
                    else if (_Keuze == 5)
                    {
                        //afsluittekst
                        Console.WriteLine("tot een volgende keer");
                        Console.WriteLine("\nDruk op enter om af te sluiten.");
                        Console.ReadKey();
                    }
                    // In elk ander geval
                    else
                    {
                        // Foutmelding
                        Console.WriteLine("U gaf geen geldige waarde in.");
                        Console.WriteLine("\nDruk op enter om terug te keren naar het hoofdmenu.");
                        Console.ReadKey();
                    }
                }
                catch
                {
                    // Scherm wissen
                    Console.Clear();

                    // Foutmelding
                    Console.WriteLine("U gaf geen geldige waarde in.");
                    Console.WriteLine("\nDruk op enter om terug te keren naar het hoofdmenu.");
                    Console.ReadKey();
                }
            }
            while (_Keuze != 5);

        }
    }
}
