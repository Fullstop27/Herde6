using System;
using System.Collections.Generic;
using System.Text;

namespace Herde6
{
    public class Antilope : IAntilope

    {
        private enGeschlecht _sex;
        private string _name;

        public Antilope(enGeschlecht sex, string name)
        {
            _sex = sex;
            _name = name;
        }

        public enGeschlecht Sex
        {
            get => _sex;
        }

        public void runTo(double angle, double speed)
        { 
        }
    }
}
