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
    }

    public interface IAntilope

    {

         static enGeschlecht Geschlecht { get; set; }
        static string name { get; set; }

        void runTo(double angle, double speed, double strecke) { }
        void runTo(double angle, double speed) { }
        void runTo(double angle) { }




    }
}
