using System;

//countdown with delay
class countdown
{
    static void Main(string[] args)
    {
        int zahl;
        // get user input
        Console.WriteLine("Geben sie eine Zahl ein");
        zahl = Convert.ToInt32(Console.ReadLine());
        
        // countdown
        for (int i = 0; i <= zahl; i++)
        {
            Console.WriteLine(i);
            System.Threading.Thread.Sleep(1000);
        }
        // wait for user to press a key
        Console.ReadKey();
    }
}
