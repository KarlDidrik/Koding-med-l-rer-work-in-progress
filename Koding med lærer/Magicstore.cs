using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koding_med_lærer
{
    internal class Magicstore
    {


        List<string> animal
        = new List<string>(){"Owl", "Rat", "Cat"};

        private List<string> wand = new List<string>() {"pheonixwand", "unicornwand", "trollwand"};

        public void Store(harrypotter customer)
        {
            Console.WriteLine("Welcome to the magic store. What would you like to take a look at?");
            Console.WriteLine("Would you like to see my pets (1) or wands (2) ?");
            var input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("I have these pets available");
                foreach (var pet in animal)
                {
                    Console.WriteLine($"{pet}");
                }
            }
            else 
            {
                foreach (var wands in wand)
                {
                    Console.WriteLine($"{wands}");
                }
            }




        }
    }
}
