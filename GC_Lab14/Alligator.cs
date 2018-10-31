using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab14
{
    class Alligator : Countable
    {
        //include instance variable that stores the count and method to return formatted count.

        public int count = 0;
        
        public void IncrementCount()
        {
            count += 1;
        }
        public void ResetCount()
        {
            count = 0;
        }
        public int GetCount()
        {
            return count;
        }
        public string GetCountString()
        {
            // this should be the method that returns the formatted string?
            return $"Alligator count = {count}";

        }
        
            
    }
}
