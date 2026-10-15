using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _12_RU_Afronden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rayven Uyttersprot
            // 13/10/2026
            // Project Afronden

            // Velden
            float floatvar = 0;
            double doublevar = 0;
            decimal decimalvar = 0;

            // Programma

            //Stap 1: Bereken 0.1 + 0.2 in de 3 typen van variabelen
            floatvar = 0.1f + 0.2f;
            doublevar = 0.1 + 0.2;
            decimalvar = 0.1M + 0.2M;

            //Stap 2: toon de resultaten
            Console.WriteLine($"float: {floatvar}");
            Console.WriteLine($"double: {doublevar}");
            Console.WriteLine($"decimal: {decimalvar}");

            Console.WriteLine("\nDruk op enter om verder te gaan");
            Console.ReadKey();
            // Scherm wissen
            Console.Clear();

            //Stap 3: Ga na of float exact 0.3 weergeeft
            if (floatvar == 0.3)

            {
                //	Als - ja
                //      Stap 4: Toon “exact 0.3”
                Console.WriteLine("float: Exact 0.3");
            }

            //	Als nee
            else
            {
                //      Stap 5: Toon “Niet 0.3”
                Console.WriteLine("float: Niet 0.3");
            }


            //Stap 6: Ga na of double exact 0.3 weergeeft
            if (doublevar == 0.3)
            {
                //	Als - ja
                //      Stap 7: Toon “exact 0.3”
                Console.WriteLine("Double: Exact 0.3");
            }
            else
            {

                //	Als nee
                //      Stap 8: Toon “Niet 0.3”
                Console.WriteLine("Double: Niet 0.3");
            }

            //Stap 9: Ga na of decimal exact 0.3 weergeeft
            if (decimalvar == 0.3M)
            {
                //	Als - ja
                //      Stap 10: Toon “exact 0.3”
                Console.WriteLine("Decimal: Exact 0.3");
            }
            else
            {
                //	Als nee
                //      Stap 11: Toon “Niet 0.3”
                Console.WriteLine("Decimal: Exact 0.3");
            }

            Console.WriteLine("\nDruk op enter om verder te gaan");
            Console.ReadKey();

        }
    }
}
