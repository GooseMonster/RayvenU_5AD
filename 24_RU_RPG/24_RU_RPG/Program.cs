using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_RU_RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rayven Uyttersprot
            // 18/11/2026
            // Project RPG

            // Velden
            Byte _keuze = 0;
            String _naamGebruiker = null;
            const String _overlord = " De Overlord";

            // Programma
            do
            {
                // Stap 1: Toon het keuzemenu + opslaan keuze gebruiker
                Console.WriteLine("Welkom avonturier, maak een keuze uit het onderstaand menu : \n");
                Console.WriteLine(" 1) Begin het avontuur   \n 2) Sluit het avontuur af");
                _keuze = Convert.ToByte(Console.ReadLine());

                // Scherm wissen
                Console.WriteLine("Druk op Enter om het verhaal verder te zetten.");
                Console.ReadKey();
                Console.Clear();

                // Stap 2: Vraag de avonturier zijn naam + opslaan
                Console.Write("Top dat u aan het avontuur wilt beginnen! \nWat zal u avontuurnaam zijn? : ");
                _naamGebruiker = Console.ReadLine();

                // Scherm wissen
                Console.Clear();

                Console.WriteLine($"Dag {_naamGebruiker}, Ik ben {_overlord} en zal u begeleiden tijdens dit avontuur.");

                
                
            }
            while (_keuze != 2);



        }
    }
}
