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
            int intDeler = 5, intDeeltal = 3;
            double doubleDeler = 5, doubleDeeltal = 3;
            decimal decimalDeler = 5m, decimalDeeltal = 3m;

            // Programma

            Console.WriteLine("Normale deling met / :");
            Console.WriteLine($"met int deler en int deeltal {(intDeeltal / intDeler).ToString()}");
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

        }   
    }
}
