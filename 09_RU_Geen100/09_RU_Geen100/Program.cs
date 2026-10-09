using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_RU_Geen100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rayven Uyttersprot
            // 09/10/2026
            // Project Geen100

            // Velden
            int _getal = 0;
            const int _honderd = 100;

            // Programma

            // Stap 1: vraag het positief getal dat geen 100 is + opslaan
            Console.Write("Geef een positief getal dat niet 100 is: ");
            _getal = int.Parse(Console.ReadLine());

            // Scherm wissen
            Console.Clear();

            // Stap 2: Kijk na of het getal kleiner of groter dan honderd is
            if (_getal > _honderd)
            {
                Console.WriteLine("Je getal was groter dan honderd ");
            }
            else if (_getal < _honderd)
            {
                Console.WriteLine("Je getal was kleiner dan honderd ");
            }
            else 
            {
                Console.WriteLine("Je getal was tegen de regels");
            }
            // Scherm wissen
            Console.WriteLine("\nDruk op enter om af te sluiten ");
            Console.ReadKey();
            Console.Clear();
            

        }
    }
}
