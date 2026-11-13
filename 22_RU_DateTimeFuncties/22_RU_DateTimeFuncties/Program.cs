using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_RU_DateTimeFuncties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rayven Uyttersprot
            // 12/11/2026
            // Project Toon Datum

            // Velden 
            DateTime _datum = DateTime.MinValue;


            // Programma

            // Stap 1: neem de datum van vandaag + toon op het scherm
            _datum = DateTime.Now;
            Console.WriteLine($"De datum en tijd van vandaag: {_datum.ToString()}\n");

            // Neem enkel de datum zonder de tijd
            _datum = DateTime.Today;
            Console.WriteLine($"De datum en tijd van vandaag: {_datum.ToString()}\n");

            _datum = DateTime.Now.Date;
            Console.WriteLine($"De datum en tijd van vandaag: {_datum.ToString()}\n");

            // Jaar van de huidige datum
            _datum = DateTime.Now;
            Console.WriteLine($"Het jaar van vandaag: {_datum.Year.ToString()}\n");

            // dag van de huidige datum
            Console.WriteLine($"De dag van vandaag: {_datum.Day.ToString()}\n");

            // Uur van de huidige datum
            Console.WriteLine($"Het uur van vandaag: {_datum.Hour.ToString()}\n");

            // Dag van de week
            Console.WriteLine($"De dag van de week: {_datum.DayOfWeek.ToString()}\n");
            int uitkomst = Convert.ToInt32(_datum.DayOfWeek);
            Console.WriteLine($"{uitkomst.ToString()} \n");

            // Toevoegen van jaren, maanden, dagen, uren, minuten, seconden...
            _datum = _datum.AddYears(1).AddMonths(5).AddDays(4).AddHours(2).AddMinutes(20);
            Console.WriteLine($"Het uur van vandaag: {_datum.ToString()}\n");
            _datum = _datum.AddYears(-1).AddMonths(-5).AddDays(-4).AddHours(-2).AddMinutes(-20);
            Console.WriteLine($"Het uur van vandaag: {_datum.ToString()}\n");

            // De verschillende ToString mogelijkheden
            Console.WriteLine("Hier zijn de verschillende ToString opties: \n");
            Console.WriteLine($"De normale ToString: {_datum.ToString()}\n");
            Console.WriteLine($"De Long Date: {_datum.ToLongDateString()}\n");
            Console.WriteLine($"De Long Time: {_datum.ToLongTimeString()}\n");
            Console.WriteLine($"De Short Date: {_datum.ToShortDateString()}\n");
            Console.WriteLine($"De Short Time: {_datum.ToShortTimeString()}\n");

            // Rekenen met datums
            DateTime datum2 = DateTime.Now.AddYears(3);
            // Rechstreeks rekenen met datums gaat niet!
            // _datum = datum2 - _datum;

            // Je moet een variabele gebruiken van et datatype TimeSpan.
            TimeSpan verschil = datum2 - _datum;


            Console.WriteLine($"{verschil.ToString()} \n");

            double aantalDagen = verschil.Days; // Geeft het aantal dagen afgerond
            double aantalDagen2 = verschil.TotalDays; // Kan een kommagetal zijn

            Console.WriteLine($"Days = {aantalDagen.ToString()} en TotalDays = {aantalDagen2.ToString()}\n");

            double aantalUren = verschil.Hours; // Geeft het aantal dagen afgerond
            double aantalUren2 = verschil.TotalHours; // Kan een kommagetal zijn

            Console.WriteLine($"Hours = {aantalUren.ToString()} en TotalHours = {aantalUren2.ToString()}\n");

            Console.WriteLine("Druk op enter om verder te gaan");
            Console.ReadKey();

            // Scherm wissen
            Console.Clear();

            // Laat de gebruiker een datum ingeven
            Console.Write("Geef een datum in (dd/mm/jjjj): ");
            string datum = Console.ReadLine();

            Console.Write("Geef een bepaald tijdstip van deze dag in (hh:mm): ");
            String tijdstip = Console.ReadLine();

            try
            {

                DateTime ingegevenDatum = DateTime.Parse($"{datum} {tijdstip}");
                DateTime enkelDatum = DateTime.Parse($"{datum}");
                DateTime enkelUur = DateTime.Parse($"{tijdstip}");

                Console.WriteLine($"\nHier is de volledige datum en tijd : {ingegevenDatum.ToString()}");
                Console.WriteLine($"Hier is enkel de datum : {enkelDatum.ToString()}");
                Console.WriteLine($"Hier is enkel de tijd : {enkelUur.ToString()}");

                // bevestiging
                Console.WriteLine("\nGelukt");
                Console.WriteLine("\n\nDruk op enter om verder te gaan ");
                Console.ReadKey();

                // Scherm wissen
                Console.Clear();

                // zeg of de ingegeven datum vroeger of later dan vandaag is
                if(_datum.Date < ingegevenDatum)
                {
                    Console.WriteLine("\nJouw ingegeven datum ligt in de toekomst!");
                }
                else if (_datum.Date > ingegevenDatum)
                {
                    Console.WriteLine("\nJouw ingegeven datum ligt in het verleden!");

                }
                else
                {
                    Console.WriteLine("\nJouw ingegeven datum is de dag van vandaag.");

                }
                Console.WriteLine("\n\nDruk op enter om verder te gaan ");
                Console.ReadKey();
            }
            catch
            {
                // Foutcode
                Console.WriteLine("Er ging iets mis. ");
                Console.WriteLine("\nDruk op enter om verder te gaan ");
                Console.ReadKey();

            }


        }
    }
}
