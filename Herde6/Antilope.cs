using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Herde6
{
    public class Antilopenmann : IAntilope
    {
        public enGeschlecht Geschlecht { get; }
        public String Name { get; }
        public Antilopenfrau Mutter { get; }
        public Antilopenmann Vater { get; }
        public int Generation { get; }
        public Condition Condition { get; }

        public Antilopenmann(Antilopenfrau mutter, Antilopenmann vater)
        {

            this.Geschlecht = enGeschlecht.Maennchen;
            this.Name = exAntilope.CreateName(this.Geschlecht);
            this.Mutter = mutter;
            this.Vater = vater;
            this.Generation = this.Vater.Generation + 1;
        }

        public Antilopenmann()
        {
            this.Geschlecht = enGeschlecht.Maennchen;
            this.Name = exAntilope.CreateName(this.Geschlecht);
            this.Mutter = null;
            this.Vater = this;
            this.Condition = exAntilope.CreateConditionOfBaby(this.Vater, this.Mutter);
            this.Generation = 0;
        }


    }






    public class Antilopenfrau : IAntilope
    {
        public enGeschlecht Geschlecht { get; }
        public string Name { get; }
        public Antilopenmann Vater { get; }
        public Antilopenfrau Mutter { get;}
        public int Generation { get; }
        public Condition Condition { get; }
        


        public Antilopenfrau(Antilopenfrau mutter, Antilopenmann vater)
        {
            this.Geschlecht = enGeschlecht.Weibchen;
            this.Name = exAntilope.CreateName(this.Geschlecht);
            this.Vater = vater;
            this.Mutter = mutter;
            this.Generation = this.Vater.Generation + 1;
            this.Condition = exAntilope.CreateConditionOfBaby(this.Vater, this.Mutter);
        }

        public Antilopenfrau()
        {
            this.Geschlecht = enGeschlecht.Weibchen;
            this.Name = exAntilope.CreateName(this.Geschlecht);
            this.Mutter = this;
            this.Vater = null;
            this.Condition = exAntilope.CreateConditionOfBaby(this.Vater, this.Mutter);
            this.Generation = 0;
        }

        
        public IAntilope MakeBabyWith(Antilopenmann father)
        {
            IAntilope b;
            if (exAntilope.CreateSex() == enGeschlecht.Maennchen)
            {
                b = new Antilopenmann(this, father);
            }
            else
            {
                b = new Antilopenfrau(this, father);
            }
            return b;
        }
        
    }



    public static class exAntilope
    {
        public static String CreateName(enGeschlecht sex)
        {
            //Guid g = Guid.NewGuid();
            //return g.ToString();
            
            return Guid.NewGuid().ToString();
        }

        public static enGeschlecht CreateSex()
        {
            int n = new Random().Next();
            enGeschlecht g = enGeschlecht.Maennchen;
            if (n % 2 == 0)
            {
                g = enGeschlecht.Weibchen;
            }            
            return g;
        }

        public static Condition CreateConditionOfBaby(Antilopenmann vater, Antilopenfrau mutter)
        {
            Condition child;
            child.Beauty = 10;
            child.Alter = 1;
            child.Fun = 10;
            child.Health = 10;


            if (mutter == null & vater != null)
            {
                child.Beauty = vater.Condition.Beauty;
            }
            else if (vater == null & mutter != null)
            {
                child.Beauty = mutter.Condition.Beauty;
            }
            else
            {
                child.Beauty = System.Math.Abs(mutter.Condition.Beauty - (vater.Condition.Beauty / 2));
            }
            return child;
        }

        /*
        public static String getNameFromREST()
        {

        }
        */

    }

}
