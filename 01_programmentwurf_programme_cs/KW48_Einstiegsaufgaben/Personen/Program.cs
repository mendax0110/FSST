using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // nehme vom user name, alter und wohnort und stelle die werte dar
            Console.WriteLine("Bitte geben Sie Ihren Namen ein:");
            string name = Console.ReadLine();
            Console.WriteLine("Bitte geben Sie Ihr Alter ein:");
            int alter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie Ihren Wohnort ein:");
            string wohnort = Console.ReadLine();

            // gebe die daten aus
            Console.WriteLine("Ihr Name ist {0}, Sie sind {1} Jahre alt und wohnen in {2}", name, alter, wohnort);

            // warte auf bestätigung
            Console.WriteLine("Drücken Sie Enter um das Programm zu beenden...");
            Console.ReadKey();
        }
    }
}
