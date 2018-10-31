using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Alligator alligator = new Alligator();
            
            
            CountTestApp.TestCase();

            Sheep sheep = new Sheep("Charles");
            CountUntil.CountTill( sheep , 2);

            //sheep = new Sheep("Blumpkin");
            //sheep.Name = "Blumpkin";
            Sheep clone = sheep.Clone() as Sheep;
            clone.Name = "Blumpkin the pumpkin";
            CountUntil.CountTill(clone, 3);

            CountUntil.CountTill(sheep, 5);

            Console.ReadLine();
        }
    }
}
