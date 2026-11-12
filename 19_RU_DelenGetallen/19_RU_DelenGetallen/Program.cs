using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_RU_DelenGetallen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rayven Uyttersprot
            // 10/11/2026
            // Project DelenGetallen

            // Velden
            int intDeler = 7, intDeeltal = 3;
            double doubleDeler = 7, doubleDeeltal = 3;
            decimal decimalDeler = 7m, decimalDeeltal = 3m;

            // Programma
            
            Console.WriteLine("Normale deling met / :");
            double uitkomst = intDeeltal / intDeler;
            Console.WriteLine($"met int deler en int deeltal {uitkomst.ToString()}");

            Console.WriteLine($"met int deler en double deeltal {(doubleDeeltal / intDeler).ToString()}");
            Console.WriteLine($"met int deler en decimal deeltal {(decimalDeeltal / intDeler).ToString()}");

            Console.WriteLine();
            Console.WriteLine($"met double deler en int deeltal {(intDeeltal / doubleDeler).ToString()}");
            Console.WriteLine($"met double deler en double deeltal {(doubleDeeltal / doubleDeler).ToString()}");
            // Dit kan niet : Console.WriteLine($"met double deler en decimal deeltal {(decimalDeeltal / doubleDeler).ToString()}");
            Console.WriteLine();
            Console.WriteLine($"met decimal deler en int deeltal {(intDeeltal / decimalDeler).ToString()}");
            // Dit kan niet : Console.WriteLine($"met decimal deler en double deeltal {(doubleDeeltal / decimalDeler).ToString()}");
            Console.WriteLine($"met decimal deler en decimal deeltal {(decimalDeeltal / decimalDeler).ToString()}");

            Console.WriteLine();
            Console.WriteLine($"met een getal als deler en int deeltal {(intDeeltal / 7).ToString()}");
            Console.WriteLine($"met een getal als deler en double deeltal {(doubleDeeltal / 7).ToString()}");

            Console.WriteLine();
            Console.WriteLine($"met int als deler en een getal deeltal {(3 / intDeler ).ToString()}");
            Console.WriteLine($"met double als deler en een getal deeltal {(3 / doubleDeler).ToString()}");
        }   
    }
}
