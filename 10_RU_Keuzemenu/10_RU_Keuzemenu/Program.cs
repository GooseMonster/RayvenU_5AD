using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _10_RU_Keuzemenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rayven Uyttersprot
            // 15/10/2026
            // Project Keuzemenu

            // Velden
            Byte _keuze = 0;

            // Programma
            do
            {
                // Scherm wissen
                Console.Clear();

                //Stap 1: Toon het keuzemenu aan de gebruiker(keuze 1, 2, 3 of afsluiten
                Console.WriteLine("maak uw keuze uit onderstaand menu:");
                Console.WriteLine("\n  1) keuze1 \n  2) keuze2 \n  3) keuze3 \n  4) afsluiten");
                try
                {
                    //Stap 2: Antwoord van de gebruiker + opslaan
                    Console.Write("\nUw keuze: ");
                    _keuze = Byte.Parse(Console.ReadLine());

                    // Scherm wissen
                    Console.Clear();

                    //Stap 3: Toon de juiste tekst afhankelijk van de keuze op het scherm
                    // als 1
                    if (_keuze == 1)
                    {
                        // Toon de tekst
                        Console.WriteLine("U koos keuze1");
                    }
                    // als 2
                    else if (_keuze == 2)
                    {
                        // Toon de tekst
                        Console.WriteLine("U koos keuze2");
                    }
                    // als 3
                    else if (_keuze == 3)
                    {
                        // Toon de tekst
                        Console.WriteLine("U koos keuze3");
                    }
                    // als 4
                    else if (_keuze == 4)
                    {
                        // Toon de tekst
                        Console.WriteLine("Tot een volgende keer");
                    }
                    // als het iets anders is
                    else
                    {
                        // Foutmelding
                        Console.WriteLine("U gaf geen geldige keuze in!");
                    }
                    // Toon de tekst
                    Console.WriteLine("\nDruk op enter om verder te gaan.");
                    Console.ReadKey();
                }
                catch 
                {
                    // Scherm wissen
                    Console.Clear();
                    // Foutmelding
                    Console.WriteLine("Uw gaf geen getal in!");
                    Console.WriteLine("\nDruk op enter om naar het keuzemenu te gaan.");
                    Console.ReadKey();
                }

                //Stap 4: als keuze niet 4 is, ga naar stap 1
            } while (_keuze != 4);


        }
    }
}
