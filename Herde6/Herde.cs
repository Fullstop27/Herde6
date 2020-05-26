using System;
using System.Collections.Generic;
using System.Text;

namespace Herde6
{
    class Herde
    {
        private List<IAntilope> lHerde;
        
        public Herde()
        {

            lHerde = new List<IAntilope>();

        }


        public IAntilope NeuesLeben()
        {
            return new Antilope(enGeschlecht.Maennchen, "");
        }


    }
}
