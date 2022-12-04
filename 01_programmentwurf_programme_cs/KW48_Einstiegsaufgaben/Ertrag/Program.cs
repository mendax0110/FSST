using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ertrag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // eingabe startkapital, eingabe anzahl der jahre, startkapital + ((Startkapital * jahre) * 10%),
            Console.WriteLine("Bitte geben Sie das Startkapital ein: ");
            double startkapital = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Bitte geben Sie die Anzahl der Jahre ein: ");
            double jahre = Convert.ToDouble(Console.ReadLine());

            double ertrag = startkapital + ((startkapital * jahre) * 0.1);

            Console.WriteLine("Der Ertrag beträgt: " + ertrag);

            Console.ReadKey();
        }
    }
}
