using System;

// benutzer gibt eine zahl ein und programm zählt bis zu dieser zahl
namespace notenrechner
{
    class notenrechner
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben sie eine Zahl ein");
            int zahl = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (i <= 85)
            {
                Console.WriteLine("Wollen sie eine weitere Zahl eingeben? (j/n)");
                string eingabe = Console.ReadLine();
                if (eingabe == "j")
                {
                    Console.WriteLine("Geben sie eine Zahl ein");
                    zahl = Convert.ToInt32(Console.ReadLine());
                    i = 0;
                }
                else if (eingabe == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Falsche Eingabe");
                }
            }
            if (zahl <= 35)
            {
                Console.WriteLine("Sie haben eine 6");
            }
            else if (zahl <= 45)
            {
                Console.WriteLine("Sie haben eine 5");
            }
            else if (zahl <= 55)
            {
                Console.WriteLine("Sie haben eine 4");
            }
            else if (zahl <= 65)
            {
                Console.WriteLine("Sie haben eine 3");
            }
            else if (zahl <= 75)
            {
                Console.WriteLine("Sie haben eine 2");
            }
            else if (zahl <= 85)
            {
                Console.WriteLine("Sie haben eine 1");
            }
            else
            {
                Console.WriteLine("Fehler");
            }
        }
    }
}
