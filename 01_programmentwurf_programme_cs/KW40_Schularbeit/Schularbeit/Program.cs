using System;

// students write a test, if 50 percent of the tests negative, the test has to be repeated
class Schularbeit
{
    static void Main(string[] args)
    {
        int anzahl;
        Console.WriteLine("Wie viele Schüler haben die Schularbeit geschrieben?");
        anzahl = Convert.ToInt32(Console.ReadLine());
        int[] noten = new int[anzahl];

        for (int i = 0; i < anzahl; i++)
        {
            Console.WriteLine("Schüler {0} hat die Schularbeit geschrieben?", i);
            string antwort = Console.ReadLine();
            
            if (antwort == "ja")
            {
                Console.WriteLine("Schüler {0} hat die Schularbeit geschrieben", i);
                Console.WriteLine("Schüler {0} hat die Schularbeit bestanden?", i);
                string antwort2 = Console.ReadLine();
                
                if (antwort2 == "ja")
                {
                    Console.WriteLine("Schüler {0} hat die Schularbeit bestanden", i);
                    noten[i] = 1;
                }
                else
                {
                    Console.WriteLine("Schüler {0} hat die Schularbeit nicht bestanden", i);
                    noten[i] = 0;
                }
            }
            else
            {
                Console.WriteLine("Schüler {0} hat die Schularbeit nicht geschrieben", i);
                noten[i] = 0;
            }
        }

        int summe = 0;
        
        for (int i = 0; i < anzahl; i++)
        {
            summe = summe + noten[i];
        }
        if (summe < anzahl / 2)
        {
            Console.WriteLine("Die Schularbeit muss wiederholt werden");
        }
        else
        {
            Console.WriteLine("Die Schularbeit ist bestanden");
        }
        Console.ReadKey();
    }
}
