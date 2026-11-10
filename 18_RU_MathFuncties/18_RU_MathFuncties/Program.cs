using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_RU_MathFuncties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rayven Uyttersprot
            // 10/11/2026
            // Math Functies

            // Velden
            byte _keuze = 0;

            // Programma
            // Stap 1: intro
            Console.WriteLine(" Welkom in dit wiskunde programma.");
            Console.WriteLine(" Druk op een toets om te starten.");
            Console.ReadKey();
            do
            {
                // Scherm wissen
                Console.Clear();
                // Stap 2:  Toon menu(grootste of kleinste, teken en abs, afronden, macht, Vierkantswortel, Inhoud cilinder, afsluiten)
                Console.WriteLine(" === MENU ===");
                Console.WriteLine(" 1) Min of max \n 2) Bepaal het teken of absolute waarde ");
                Console.WriteLine(" 3) Afronden \n 4) Machtsverheffing \n 5) Vierkantswortel");
                Console.WriteLine(" 6) Inhoud cilinder \n 7) Afsluiten");

                try
                {
                    // Stap 3: Vraag keuze +opslaan
                    Console.Write("Geef uw keuze: ");
                    _keuze = byte.Parse(Console.ReadLine());
                    // Stap 4:
                    // Scherm wissen
                    Console.Clear();

                    // Als 1: grootste of kleinste
                    if (_keuze == 1)
                    {
                        bool herhalen = true;
                        do
                        {
                            try
                            {
                                // Scherm wissen
                                Console.Clear();
                                // Stap 5: Vraag 2 getallen + opslaan
                                Console.Write("Geef een eerste getal in: ");
                                int getal1 = int.Parse(Console.ReadLine());

                                Console.Write("\nGeef een tweede getal in: ");
                                int getal2 = int.Parse(Console.ReadLine());

                                // Scherm wissen
                                Console.Clear();

                                // Stap 6: toon menu(kleinst, grootste )
                                Console.WriteLine("Welke bewerking wil je uitvoeren?");
                                Console.WriteLine(" 1) Bepaal het minimum");
                                Console.WriteLine(" 2) Bepaal het maximum");

                                try
                                {
                                    Console.Write("\n Geef uw keuze: ");
                                    byte keuze = byte.Parse(Console.ReadLine());

                                    // Scherm wissen
                                    Console.Clear();


                                    // Stap 7: geef het juiste antwoord
                                    if (keuze == 1)
                                    {
                                        Console.WriteLine($"Het minimum is: {Math.Min(getal1, getal2).ToString()}");
                                        Console.ReadKey();

                                        // Lussen stoppen
                                        herhalen = false;
                                    }
                                    else if (keuze == 2)
                                    {
                                        Console.WriteLine($"Het maximum is: {Math.Max(getal1, getal2).ToString()}");
                                        Console.ReadKey();

                                        // Lussen stoppen
                                        herhalen = false;
                                    }
                                    else
                                    {
                                        // Foutmelding
                                        Console.WriteLine("U gaf geen getal in.");
                                        Console.WriteLine("Druk op enter om terug te keren naar het hoofdmenu");
                                        Console.ReadKey();
                                    }


                                }
                                catch
                                {
                                    //Scherm Wissen
                                    Console.Clear();

                                    // Foutmelding
                                    Console.WriteLine("U gaf geen getal in.");
                                    Console.WriteLine("Druk op enter om terug te keren naar het hoofdmenu");
                                    Console.ReadKey();
                                }
                            }
                            catch
                            {
                                //Scherm Wissen
                                Console.Clear();

                                // Foutmelding
                                Console.WriteLine("U gaf geen getal in.");
                                Console.WriteLine("Druk op enter om terug te keren naar het hoofdmenu");
                                Console.ReadKey();
                            }


                        } while (herhalen);

                    }


                    // Als 2: teken en absolute waarde
                    else if (_keuze == 2)
                    {
                        bool herhalen = true;
                        do
                        {
                            // Scherm wissen
                            Console.Clear();
                            try
                            {
                                //        Stap 8: vraag getal +opslaan
                                Console.Write("Geef een getal in: ");
                                int getal1 = int.Parse(Console.ReadLine());

                                // Scherm Wissen
                                Console.Clear();

                                // Toon het menu
                                Console.WriteLine("Welke bewerking wil je uitvoeren?");
                                Console.WriteLine(" 1) Geef weer of het getal positief of negatief is ");
                                Console.WriteLine(" 2) Geef de absolute waarde");


                                try
                                {
                                    Console.Write("\n Geef uw keuze: ");
                                    byte keuze = byte.Parse(Console.ReadLine());

                                    // Scherm wissen
                                    Console.Clear();


                                    // Stap 9: Toon positief of negatief
                                    if (keuze == 1)
                                    {
                                        // Kijk of het getal positief is
                                        if (Math.Sign(getal1) == 1)
                                        {
                                            Console.WriteLine($"Het getal is positief ");
                                            Console.ReadKey();

                                            // Lussen stoppen
                                            herhalen = false;
                                        }
                                        // Kijk of het 0 is
                                        else if (Math.Sign(getal1) == 0)
                                        {
                                            Console.WriteLine($"Het getal is nul");
                                            Console.ReadKey();

                                            // Lussen stoppen
                                            herhalen = false;
                                        }
                                        // Anders is het negatief
                                        else
                                        {
                                            Console.WriteLine("Het getal is negatief");
                                        }
                                        Console.ReadKey();
                                    }
                                    // Stap 10: Toon absolute waarde
                                    else if (keuze == 2)
                                    {
                                        Console.WriteLine($"Het absolute waarde van het getal is: {Math.Abs(getal1).ToString()}");
                                        Console.ReadKey();

                                        // Lussen stoppen
                                        herhalen = false;
                                    }
                                    else
                                    {
                                        // Foutmelding
                                        Console.WriteLine("U gaf geen getal in.");
                                        Console.WriteLine("Druk op enter om terug te keren naar het hoofdmenu");
                                        Console.ReadKey();
                                    }

                                }
                                catch
                                {
                                    // Foutmelding
                                    Console.WriteLine("U gaf geen juist getal in.");
                                    Console.WriteLine("Druk op enter om terug te keren naar het hoofdmenu");
                                    Console.ReadKey();
                                }
                            }
                            catch
                            {
                                // Foutmelding
                                Console.WriteLine("U gaf geen juist getal in.");
                                Console.WriteLine("Druk op enter om terug te keren naar het hoofdmenu");
                                Console.ReadKey();
                            }
                        } while (herhalen);
                    }

                    //    Als 3: afronden
                    else if (_keuze == 3)
                    {
                        bool herhalen = true;
                        do
                        {
                            // Scherm wissen
                            Console.Clear();



                            try
                            {
                                // Stap 11: Vraag een kommagetal van minstens 3 cijfers na de komma
                                Console.Write("Geef een getal met minstens 3 cijfers na de komma in: ");
                                double getal1 = double.Parse(Console.ReadLine().Replace(".", ","));

                                // Scherm wissen
                                Console.Clear();

                                // Stap 12: Ga na of er 3 cijfers zijn na de komma
                                if (getal1.ToString().IndexOf(",") != -1 && (getal1.ToString().Length - getal1.ToString().IndexOf(",") > 3))
                                {
                                    // Stap 13: Toon het getal afgerond na de komma
                                    Console.WriteLine($"Het afgeronde getal is: {Math.Round(getal1, 2).ToString()} ");
                                    // Stap 14 : toon het getal afgerond naar dichtstbijzijnde natuurlijk getal
                                    Console.WriteLine($"Het afgeronde naar dichtsbeijzijnde natuurlijk getal is: {Math.Round(getal1).ToString()} ");
                                    // Stap 15: Toon het getal met het 2de cijfer na de komma afgerond naar boven
                                    Console.WriteLine($"Het afgeronde met het 2de cijfer na de komma afgerond naar boven getal is: {Math.Ceiling((Math.Round(getal1, 2) * 100) / 100).ToString()} ");
                                }
                                else
                                {
                                    // Scherm wissen
                                    Console.Clear();
                                    // Foutmelding
                                    Console.WriteLine("U gaf geen juist getal in.");
                                    Console.WriteLine("Druk op enter om terug te keren naar het hoofdmenu");
                                    Console.ReadKey();
                                }

                                Console.WriteLine("\n Druk op enter om terug te keren naar het hoofdmenu");
                                Console.ReadKey();

                                // Lussen stoppen
                                herhalen = false;
                            }
                            catch
                            {
                                // Scherm wissen
                                Console.Clear();
                                // Foutmelding
                                Console.WriteLine("U gaf geen juist getal in.");
                                Console.WriteLine("\n Druk op enter om terug te keren naar het hoofdmenu");
                                Console.ReadKey();
                            }
                        } while (herhalen);

                    }


                    //    Als 4: 	Macht
                    else if (_keuze == 4)
                    {
                        bool herhalen = true;
                        do
                        {
                            // Scherm wissen
                            Console.Clear();



                            try
                            {
                                //        Stap 16: Vraag een getal + opslaan
                                Console.Write(" Geef een getal in.");
                                int getal1 = int.Parse(Console.ReadLine());
                                //        Stap 17: Bereken de 2de, 3de en 4de macht
                                double tweede = Math.Pow(getal1, 2);
                                double derde = Math.Pow(getal1, 3);
                                double vierde = Math.Pow(getal1, 4);
                                //        Stap 18: Toon resultaat
                                Console.WriteLine("Hier zijn de uitkomsten van de verschillende machten; ");
                                Console.WriteLine($"Tot de tweede macht: {tweede.ToString()}");
                                Console.WriteLine($"Tot de derde macht: {derde.ToString()}");
                                Console.WriteLine($"Tot de vierde macht: {vierde.ToString()}");
                            }
                            catch
                            {

                            }
                        }
                        while (herhalen);
                        
                        
                    }


                    //    Als 5: Vierkantswortel
                    else if (_keuze == 5)
                    {
                        bool herhalen = true;
                        do
                        {
                            // Scherm wissen
                            Console.Clear();



                            try
                            {
                                //        Stap 19: Vraag een getal + opslaan
                                Console.Write(" Geef een getal in.");
                                int getal1 = int.Parse(Console.ReadLine());
                                //        Stap 20: Bereken de vierkantswortel + afronden
                                double uitkomst = Math.Sqrt(getal1);
                                //        Stap 21: Toon resultaat
                                Console.WriteLine($"De vierkantswortel van het getal = {uitkomst.ToString()}");
                            }
                            catch
                            {
                                // Scherm wissen
                                Console.Clear();
                                // Foutmelding
                                Console.WriteLine("U gaf geen juist getal in.");
                                Console.WriteLine("\n Druk op enter om terug te keren naar het hoofdmenu");
                                Console.ReadKey();
                            }
                        } while (herhalen);
                    }


                    //    Als 6: Inhoud cilinder
                    else if (_keuze == 6)
                    {
                        double straal = 0;
                        double hoogte = 0;
                        double omtrek = 0;
                        double inhoud = 0;

                        // Programma
                        
                        
                            // Stap 22: Toon de gebruiker een keuzemenu voor 1) berekenen van inhoud en omtrek van een cilinder. 2) Afsluiten
                            

                            // Scherm Wissen
                            Console.Clear();

                            try
                            {
                                // Stap 23: 
                                // Als keuze 1: vraag de gebruiker om een straal van het grondvlak van de cilinder en de hoogte van een cilinder
                                 
                                
                                    Console.Write("Geef de straal van het grondvlak van de cilinder in centimeter: ");
                                    straal = double.Parse(Console.ReadLine());

                                    Console.Write("Geef de hoogte van de cilinder in centimeter: ");
                                    hoogte = double.Parse(Console.ReadLine());

                                    // Scherm Wissen
                                    Console.Clear();

                                    // Stap 24: Bereken en toon de uitkomst van de cilinder
                                    omtrek = 2 * straal * Math.PI;
                                    inhoud = Math.PI * Math.Pow(straal, 2) * hoogte;

                                    Console.WriteLine($"De omtrek van de cilinder is: {omtrek} centimeter ");
                                    Console.WriteLine($"De inhoud van de cilinder is: {inhoud} centimeter ");

                                    // Scherm wissen
                                    Console.WriteLine("\nDruk op enter om terug te keren naar het menu");
                                    Console.ReadKey();
                                    Console.Clear();
                                
                                // Stap 25: Zolang keuze niet 2 is, ga terug naar stap 1
                            }
                            catch
                            {
                                // Scherm Wissen
                                Console.Clear();

                                Console.WriteLine("Je hebt iets fout ingegeven.");
                            }
                        }
                        
                    


                    // Als 7 :
                    else if (_keuze == 7)
                    {
                        //Stap 25: Toon afsluittekst
                        Console.WriteLine("Tot de volgende keer! ");
                        Console.WriteLine("Druk op enter om terug te keren naar het hoofdmenu");
                        Console.ReadKey();
                    }


                    //Stap 26: Als keuze niet 7 is: ga terug naar stap 2
                    else
                    {
                        // Foutmelding
                        Console.WriteLine("U gaf geen juist getal in.");
                        Console.WriteLine("Druk op enter om terug te keren naar het hoofdmenu");
                        Console.ReadKey();
                    }
                }
                catch
                {
                    //Scherm Wissen
                    Console.Clear();
                    // Foutmelding
                    Console.WriteLine("U gaf geen getal in.");
                }
            } while (_keuze != 7);



        }
    }
}
