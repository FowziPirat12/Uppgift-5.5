using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många frågor vill du ställa mig?");
            int frågor = int.Parse(Console.ReadLine());
            
            int[] v = new int[frågor];
            Random random = new Random();

            string[] s = { "Ja", "Nej", "kanske...", "Warya Nej!!", "Är du dum eller??", "Yacni.. jag tror det??", "Fråga siri", "Jag tycker inte det", "Kanske är det så", "Vi får hoppas på det", "Tänker inte svarapå det", "Nej, defenetivt inte", };

            int antalfrågor = 0;

            for (int i = 0; i < frågor; i++)
            {
                antalfrågor++;
                Console.WriteLine($"Vad är det du undrar? {antalfrågor} av {frågor} frågor");
                Console.WriteLine();
                Console.WriteLine("- " + s[random.Next(10)]);
                Console.WriteLine();

                
            }
        }
    }
}