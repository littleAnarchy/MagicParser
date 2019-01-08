using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOPApp
{
    public class Horse : Mammal
    {
        public static int HorseCount;
        public Horse()
        {
            Name = "Кінь";
            HorseCount++;
        }

        public Horse(string name)
        {
            Name = name;
            HorseCount++;
        }

        ~Horse()
        {
            Console.WriteLine($"Horse {Name} die");
        }
    }
}
