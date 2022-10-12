using System;

// Termin wird versendet, sind alle Teilnehmer zufrieden, wird der Termin bestätigt
class Terminkoordination
{
    static void Main(string[] args)
    {
        int teilnehmerzahl;
        // Teilnehmerzahl einlesen
        Console.WriteLine("Wie viele Teilnehmer sind zugesagt?");
        teilnehmerzahl = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i <= teilnehmerzahl; i++)
        {
            // Überprüfen, ob alle Teilnehmer zufrieden sind
            Console.WriteLine("Teilnehmer {0} ist zufrieden?", i);
            string antwort = Console.ReadLine();
            
            // wenn ja -> Termin bestätigen, wenn nein -> Termin abbrechen
            if (antwort == "ja")
            {
                Console.WriteLine("Termin wird bestätigt");
            }
            else
            {
                Console.WriteLine("Termin wird abgesagt");
            }
        }
        Console.ReadKey();
    }
}