using System;
using System.Collections.Generic;
using System.Text;

namespace Herde6
{
    public enum enGeschlecht
    {
        Maennchen,
        Weibchen
    }

    public struct Position
    {
        
        public double x { get; set; }
        public double y { get; set; }
        public void move() { }
    }

    public struct Condition
    {
        public int Beauty;
        public int Health;
        public int Fun;
        public int Alter;
    }

    public interface IAntilope
    {

        public enGeschlecht Geschlecht { get; }
        public String Name { get; }
        public Antilopenmann Vater { get; }
        public Antilopenfrau Mutter { get; }
        public int Generation { get; }
        public Condition Condition { get; }

           

       /* 
        public void runTo(double angle, double speed, double strecke) { }
        public void runTo(double angle, double speed) { }
        public void runTo(double angle) { }
       */




    }
}
