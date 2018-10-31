using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab14
{
    interface Countable
    {
        void IncrementCount();
        void ResetCount();
        int GetCount();
        string GetCountString();
    }
}
