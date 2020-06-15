using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Linq;

namespace Herde6
{
    public class Herde
    {
        private List<IAntilope> Tribe = new List<IAntilope>();

 
        public Herde()
        {
            
            Antilopenfrau urmama;
            Antilopenmann urvater;
            urmama = new Antilopenfrau();
            urvater = new Antilopenmann();
            Tribe.Add(urmama);
            Tribe.Add(urvater);
        }

        public void AddNewAnimalToTribe(IAntilope newAnimal)
        {
            Tribe.Add(newAnimal);

        }

        public int GetCount()
        {
            return Tribe.Count;
        }

        public void Paarungszeit(int wunschgroesse)
        {
            //List<IAntilope> men;
               var men = from m in Tribe
                      where m.Geschlecht == enGeschlecht.Maennchen
                      select m;
            foreach (Antilopenmann n in men)
            {
                
                foreach (Antilopenfrau f in GetMother(Tribe))
                {
                    IAntilope b;
                    b = f.MakeBabyWith(n);
                    Tribe.Add(b);
                }

            }



            /*
            foreach (IAntilope ant in GetMother())
            {

            }
            Tribe.Add(baby);
            Console.WriteLine("Baby: " + baby.name);
            */
        }


        /* 
         * Paarung gibt ein True zurück wenn bei einer Paarung auch was rauskommen würde
         
        public Boolean IsPaarungMoeglich(IAntilope vater, IAntilope mutter)
        {
            return (vater.Geschlecht == enGeschlecht.Maennchen) &
                    (mutter.Geschlecht == enGeschlecht.Weibchen);
        }
        */

        private IEnumerable<Antilopenmann> GetFather(List<IAntilope> t)
        {
            foreach (IAntilope ant in t)
            {
                if (ant.Geschlecht == enGeschlecht.Maennchen)
                {
                    yield return ant as Antilopenmann;
                }
            }
        }

        private IEnumerable<Antilopenfrau> GetMother(List<IAntilope> t)
        {
            foreach (IAntilope ant in t)
            {
                if (ant.Geschlecht == enGeschlecht.Weibchen)
                {
                    yield return ant as Antilopenfrau;
                }
            }

        }

    }
}
