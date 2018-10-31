using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab14
{
    class Sheep : Countable, ICloneable
    {
        //implement countable and clonable interfaces
        //include instance variable that stores count and names of sheep
        //provides methods that get/set name of sheep (done)
        public int  count = 0;

        public string Name { get; set; }
        public Sheep(string name)
        {
            Name = name;
        }

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
            return $"{Name} count = {count}";
        }
        public object Clone()
        {
            return new Sheep(Name);
        }

    }
}
