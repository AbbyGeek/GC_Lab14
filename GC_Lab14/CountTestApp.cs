using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab14
{
    class CountTestApp 
    {
        //uses CountUntil to count the aligator class three times.
        public static void TestCase()
        {
            Alligator alligator = new Alligator();
            CountUntil.CountTill( alligator, 3);
        }
        
    }
}
