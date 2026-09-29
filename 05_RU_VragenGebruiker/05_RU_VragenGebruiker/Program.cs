using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_RU_VragenGebruiker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rayven Uyttersprot
            // 29/09/2026
            // Project Vragen Gebruiker

            // Velden
            String _kleurGebruiker = null;
            String _weekdagGebruiker = null;
            String _seizoenGebruiker = null;
            String _bewerking = null;
            String _bewerking1 = null;
            String _bewerking2 = null;

            // Programma
            // 1. Vraag de gebruikers favoriete kleur + antwoord opslaan
            Console.Write("Kies een kleur: ");
            _kleurGebruiker = Console.ReadLine();
            Console.Clear();

            // 2. Maak de juiste tekst aan + toon antwoord
            _bewerking = $"Je koos {_kleurGebruiker}";
            Console.WriteLine(_bewerking);

            //scherm wissen
            Console.WriteLine("\nDruk op een toets om verder te gaan ");
            Console.ReadKey();
            Console.Clear();


            // 3. Vraag de gebruikers favoriete weekdag + antwoord opslaan
            Console.Write("Wat is je favoriete weekdag: ");
            _weekdagGebruiker = Console.ReadLine();
            Console.Clear();

            // 4. Maak de juiste tekst aan + toon antwoord
            _bewerking1 = $"Je favoriete dag is {_weekdagGebruiker}";
            Console.WriteLine(_bewerking1);

            //scherm wissen
            Console.WriteLine("\nDruk op een toets om verder te gaan ");
            Console.ReadKey();
            Console.Clear();

            // 5. Vraag de gebruikers favoriete seizoen + antwoord opslaan
            Console.Write("Geef je favoriete seizoen: ");
            _seizoenGebruiker = Console.ReadLine();
            Console.Clear();

            // 6. Maak de juiste tekst aan + toon antwoord
            _bewerking2 = $"Je favoriete seizoen is {_seizoenGebruiker}";
            Console.WriteLine(_bewerking2);

            //scherm wissen
            Console.WriteLine("\nDruk op een toets om verder te gaan ");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
