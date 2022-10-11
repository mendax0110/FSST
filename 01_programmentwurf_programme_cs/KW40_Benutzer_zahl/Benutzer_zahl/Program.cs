using System;

// benutzer gibt eine zahl ein und programm zählt bis zu dieser zahl
class Benutzer_zahl
{
    static void Main(string[] args)
    {
        int zahl;
        // benutzer soll eine zahl eingeben
        Console.WriteLine("Geben sie eine Zahl ein");
        zahl = Convert.ToInt32(Console.ReadLine());
        
        // programm zählt bis zu der eingegebenen zahl
        for (int i = 0; i <= zahl; i++)
        {
            Console.WriteLine(i);
        }
        Console.ReadKey();
    }
}