using System;

//Supermarkt besuchen, Produkt von Einkaufsliste in Warenkorb legen, bis liste leer ist, bezaheln und verlassen
class Einkaufen
{
    static void Main(string[] args)
    {
        string[] einkaufsliste = new string[5];
        einkaufsliste[0] = "Milch";
        einkaufsliste[1] = "Brot";
        einkaufsliste[2] = "Eier";
        einkaufsliste[3] = "Käse";
        einkaufsliste[4] = "Wurst";
        string[] warenkorb = new string[5];
        int i = 0;
        
        while (i < einkaufsliste.Length)
        {
            Console.WriteLine("Produkt {0} in Warenkorb legen?", einkaufsliste[i]);
            string antwort = Console.ReadLine();
            
            if (antwort == "ja")
            {
                Console.WriteLine("Produkt {0} in Warenkorb gelegt", einkaufsliste[i]);
                warenkorb[i] = einkaufsliste[i];
                i++;
            }
            else
            {
                Console.WriteLine("Produkt {0} nicht in Warenkorb gelegt", einkaufsliste[i]);
                i++;
            }
        }
        
        Console.WriteLine("Bezahlen und verlassen");
        Console.ReadKey();
    }
}
