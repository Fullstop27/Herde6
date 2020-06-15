using System;

namespace Herde6
{
    class Program
    {
        static void Main(string[] args)
        {
            Herde t = new Herde();
            


            Console.WriteLine("Anzahl der Tiere in der Herde: " + t.GetCount());
            //Tribe.Paarungszeit(50);
            t.Paarungszeit(3);
            Console.WriteLine("Anzahl der Tiere in der Herde: " + t.GetCount());
            Console.ReadKey();
            
        }
    }
}
