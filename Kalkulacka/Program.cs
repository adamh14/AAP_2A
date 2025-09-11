using System;

class Program
{
    static void Main(string[] args)
    {
        String pokracovat; //promenna pro ulozeni info o pokracovani (a/n), musi byt deklarovana mimo cyklus, aby byla citelna v podmince while
        do
        {
            Console.WriteLine("Zadejte prvni cislo: ");
            int cislo1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte druhe cislo: ");
            int cislo2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte znamenko (+, -, *): ");
            String znamenko = Console.ReadLine();
            switch(znamenko)
            {
                case "+":
                    Console.WriteLine("Vysledek: " + (cislo1 + cislo2));
                    break;
                case "-":
                    Console.WriteLine("Vysledek: " + (cislo1 - cislo2));
                    break;
                case "*":
                    Console.WriteLine("Vysledek: " + (cislo1 * cislo2));
                    break;
                default:
                    Console.WriteLine("Chyba: neplatne znamenko.");
                    break;
            }

            //alternativni moznost pres if, else if, else
            /*
            if (znamenko == "+")
            {
                Console.WriteLine("Vysledek: " + (cislo1 + cislo2));
            }
            else if (znamenko == "-")
            {
                Console.WriteLine("Vysledek: " + (cislo1 - cislo2));
            }
            else if (znamenko == "*")
            {
                Console.WriteLine("Vysledek: " + (cislo1 * cislo2));
            }
            else
            {
                Console.WriteLine("Chyba: neplatne znamenko.");
            }
            */

            Console.WriteLine("Chcete pokracovat? (a/n)");
            pokracovat = Console.ReadLine();
        } while(pokracovat == "a");

        Console.WriteLine("Konec programu.");
    }
}