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

            Antilopenfrau urmama, urmama2;
            Antilopenmann urvater, urvater2;
            urmama = new Antilopenfrau();
            urvater = new Antilopenmann();
            urmama2 = new Antilopenfrau();
            urvater2 = new Antilopenmann();

            Tribe.Add(urmama);
            Tribe.Add(urmama2);
            Tribe.Add(urvater);
            Tribe.Add(urvater2);
        }

        public void AddNewAnimalToTribe(IAntilope newAnimal)
        {
            Tribe.Add(newAnimal);
        }

        public int GetCount()
        {
            return Tribe.Count;
        }

        public void Paarungszeit()
        {
            List<IAntilope> BabyList = new List<IAntilope>();

            var men = from m in Tribe
                      where m.Geschlecht == enGeschlecht.Maennchen
                      select m;

            var women = from m1 in Tribe
                        where m1.Geschlecht == enGeschlecht.Weibchen
                        select m1;


            foreach (IAntilope n in men)
            {
                foreach (Antilopenfrau f in women)
                {
                    if (!exAntilope.IsPaarungInzest(n as Antilopenmann, f))
                    {
                        IAntilope b;
                        b = f.MakeBabyWith(n as Antilopenmann);
                        BabyList.Add(b);
                    }
                }

            }

            foreach (IAntilope bb in BabyList)
            {
                this.AddNewAnimalToTribe(bb);
            }
        }

    }

}








