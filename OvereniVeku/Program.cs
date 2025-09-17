using System;

class Program
{
    static void Main(string[] args)
    {
        string pokracovat;
        do
        {
            Console.WriteLine("Zadej rok narození");

            string text;

            text = Console.ReadLine();

            int cislo;

            cislo = Int32.Parse(text);

            if (cislo <= 2005)
            {
                Console.WriteLine("Plnoletý");
            }
            else
            {
                Console.WriteLine("Není plnoletý");
            }
            Console.WriteLine("Pokračovat?");
            pokracovat = Console.ReadLine();
        }
        while (pokracovat == "ano");
    }
}