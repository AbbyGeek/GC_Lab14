using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab14
{
    class CountUntil
    {
        public CountUntil() { }
        //include static method that lets you count any Countable objects for a specific number of times.
        public static void CountTill(Countable c, int MaxCount)
        {
            
            for (int i = 0; i < MaxCount; i++)
            {
                c.IncrementCount();
                Console.WriteLine(c.GetCountString());
            }
            c.ResetCount();
            Console.WriteLine("\n");
        }
    }
}
