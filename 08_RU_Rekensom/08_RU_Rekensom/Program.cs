using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_RU_Rekensom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rayven Uyttersprot
            // 08/10/2026
            // Project Rekensom

            // Velden
            int _getal1 = 0;
            int _getal2 = 0;
            int _bewerking1 = 0;
            int _bewerking2 = 0;
            int _bewerking3 = 0;
            int _bewerking4 = 0;



            // Programma
            try
            {

                // Stap 1: Vraag het eerste getal + opslaan
                Console.Write("Geef een getal in onder de 1000: ");
                _getal1 = int.Parse(Console.ReadLine());


                // Scherm leegmaken
                Console.Clear();


                // Stap 2: Vraag het tweede getal + opslaan
                Console.Write("Geef een tweede getal in onder de 1000: ");
                _getal2 = int.Parse(Console.ReadLine());

                // Scherm leegmaken
                Console.Clear();

                // Stap 3: Tel de 2 getallen op + opslaan
                _bewerking1 = _getal1 + _getal2;


                // Stap 4: Voeg 5 toe bij het resultaat van de 2 getallen + opslaan
                _bewerking2 = _bewerking1 + 5;

                // Stap 5: Vermenigvuldig het resultaat van de vorige berekening met 10 + opslaan
                _bewerking3 = _bewerking2 * 10;

                // Stap 6: Deel het resultaat van de vorige bewerking door 2 + opslaan
                _bewerking4 = _bewerking3 / 2;

                // Stap 7: Geef het resultaat weer in de juiste vorm 
                Console.WriteLine($" U gaf het getal {_getal1.ToString()} en getal {_getal2.ToString()} in ");
                Console.WriteLine($" De som hiervan is {_bewerking1.ToString()}");
                Console.WriteLine($" Dit getal werd vermeerder met 5. Dit gaf als uitkomst {_bewerking2.ToString()}");
                Console.WriteLine($" Daarna werd er vermenigvuldig met 10. Dit gaf als uitkomst {_bewerking3.ToString()} ");
                Console.WriteLine($" Als laatste werd er gedeeld door 2. ");
                Console.WriteLine($" Het uiteindelijke resultaat is {_bewerking4.ToString()}");
                Console.WriteLine("\n Druk op enter om af te sluiten");
                Console.ReadKey();
            }
            catch
            {
                // Scherm leegmaken + Foutcode
                Console.Clear();
                Console.WriteLine(" er ging iets fout");
                Console.WriteLine("\n Druk op enter om af te sluiten");
                Console.ReadKey();
            }


        }
    }
}
