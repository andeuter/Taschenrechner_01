using System;

namespace Taschenrechner_01
{
    /// <summary>
    /// Erster einfacher Entwurf eines Taschenrechners,
    /// der 2 Integer-Zahlen addiert
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implementieren der beiden Summanden
            long a, b;

            // Eingabe und Konvertierung der Summanden
            Console.WriteLine("Bitte gib den ersten Summanden ein ...");
            a = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\nBitte gib den zweiten Summanden ein ...");
            b = Convert.ToInt64(Console.ReadLine());

            // Ausgabe der Addition
            Console.WriteLine("\nDie Summe von {0} + {1} ist {2}.", a, b, (a + b));

            // Programm beenden
            Console.WriteLine("\nProgramm mit 'Enter' beenden ...");
            Console.ReadKey();
        }
    }
}
