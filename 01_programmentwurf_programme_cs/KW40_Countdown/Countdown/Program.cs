using System;

//countdown with delay
class countdown
{
    static void Main(string[] args)
    {
        int zahl;
        Console.WriteLine("Geben sie eine Zahl ein");
        zahl = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i <= zahl; i++)
        {
            Console.WriteLine(i);
            System.Threading.Thread.Sleep(1000);
        }
        Console.ReadKey();
    }
}
