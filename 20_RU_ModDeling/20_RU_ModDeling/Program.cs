using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_RU_ModDeling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rayven Uyttersprot
            // 12/11/2026
            // Project ModDeling

            // Velden
            const double _deler = 7;
            const double _deeltal = 27;

            // Programma
            Console.WriteLine("deel 27 / 7");
            Console.WriteLine($"de uitkomst van de deling: {(_deeltal/_deler).ToString()}");
            Console.WriteLine($"de uitkomst van de deling: {(Math.Round(_deeltal / _deler,2)).ToString()} \n");
            Console.WriteLine($"7 gaat {(Math.Floor(_deeltal / _deler)).ToString()} in 27");
            Console.WriteLine($"de rest is dan: {(_deeltal % _deler).ToString()}");


        }
    }
}
