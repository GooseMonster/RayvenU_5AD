using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_RU_RaadSpel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rayven Uyttersprot
            // 13/11/2026
            // Project RaadSpel

            // Velden

            Byte _keuze = 0;
            // Programma

            do
            {
                // Scherm wissen
                Console.Clear();

                //  Stap 1: Toon het menu(Spel spelen, Afsluiten)
                Console.WriteLine("Maak uw keuze uit onderstaand menu:");
                Console.WriteLine("     1) Speel het spel\n     2) Afsluiten");

                try
                {
                    // Stap 2: Vraag keuze +opslaan
                    Console.Write("\nGeef uw keuze: ");
                    _keuze = Byte.Parse(Console.ReadLine());


                    // Stap 3: Als 1:
                    if (_keuze == 1)
                    {



                        //	Stap 4: Maak een willekeurig getal
                        Random rdm = new Random();
                        Byte geheimGetal = Convert.ToByte(rdm.Next(1, 101));
                        bool gevonden = false;

                        // Stap 5: Geef de gebruiker 5 kansen
                        for (int i = 5; i > 0; i--) ;
                        {

                            // Stap 6: Vraag de gokpoging van de gebruiker

                            //  Stap 7: Kijk of de gok juist is
                            //  Als de gok kleiner is:

                            //	Stap 8: Zeg het te raden getal is hoger
                            //  Als de gok hoger is:

                            //	Stap 9: Zeg het te raden getal is lager
                            //  Als de gok juist is:

                            //	Stap 10: Zeg proficiat
                        }
                        // Als de kansen op zijn:
                        // Stap 11: Zeg de kansen zijn op en toon het getal

                        // Als de gok niet juist was en er nog raad kansen over zijn, keer terug naar stap 6
                    }
                    // Als 2:
                    else if (_keuze == 2)
                    {
                        // Stap 12: Toon afsluittekst
                        Console.WriteLine("Tot een volgende keer ");
                        Console.WriteLine("\nDruk op een knop om af te sluiten. ");
                        Console.ReadKey();
                    }
                    // in elk andergeval
                    else
                    {
                        // Foutmelding
                        Console.WriteLine("U gaf geen getal in. ");
                        Console.WriteLine("\nDruk op een knop om terug te keren naar het hoofdmenu. ");
                        Console.ReadKey();
                    }
                }
                catch
                {
                    // Scherm wissen
                    Console.Clear();

                    // Foutmelding
                    Console.WriteLine("U gaf geen getal in. ");
                    Console.WriteLine("\nDruk op een knop om terug te keren naar het hoofdmenu. ");
                    Console.ReadKey();

                }

                // Stap 13: Als keuze niet 2 is, keer terug naar stap 1
            } while (_keuze != 2);

        }
    }
}
