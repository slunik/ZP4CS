using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture06
{
    static class Calcul
    {
        static short value = 0;
         
        public static short readValue()
        {
            return value;
        }

        public static void setValue(short newValue)
        {
            value = newValue;
        }
            
    }
}
