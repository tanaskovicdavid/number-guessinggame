using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateSpielLA2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Random random = new Random();
            bool nochmal = true;
            int guess;
            int versuche;
            int nummer;
            int min = 1;
            int max = 100;
            String antwort;

            while (nochmal)
            {
                guess = 0;
                versuche = 0;
                antwort = "";   
                nummer = random.Next(min, max + 1);
                try
                {
                    while (guess != nummer)
                    {
                        Console.WriteLine("Errate die Zahl von " + min + " - " + max + " : ");
                        guess = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Guess: " + guess);
                        if (guess > nummer)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine(guess + " ist zu gross!");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;

                        }
                        else if (guess < nummer)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine(guess + " ist zu klein!");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        versuche++;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Number: " + nummer);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("DU HAST GEWONNEN!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Guesses: " + versuche);
                    Console.WriteLine("Wenn du nochmal spielen willst, schreibe: \"J\". Wenn nicht, dann schreib einfach was anderes als \"J\"");
                    antwort = Console.ReadLine();
                    antwort = antwort.ToUpper();

                    if (antwort == "J")
                    {
                        nochmal = true;
                        Console.Clear();
                    }
                    else
                    {
                        nochmal = false;
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Error. Gib eine Zahl von 1 - 100 ein..");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Danke fürs Spielen!");
            Console.WriteLine("Drücke irgendeine Taste zum schliessen.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
    }
}
