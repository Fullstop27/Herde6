using System;

namespace Herde6
{
    class Program
    {
        static void Main(string[] args)
        {
            Herde t = new Herde();
            int runde = 5;
            Console.WriteLine("Anzahl der Tiere in der Herde: " + t.GetCount());

            for (int i = 1; i <= runde; i++)
            {
                t.Paarungszeit();
                Console.WriteLine("Anzahl der Tiere in der Herde: " + t.GetCount());
                Console.WriteLine("Fertig. Runde " + i);
            }
            Console.ReadKey();

        }
    }
}
