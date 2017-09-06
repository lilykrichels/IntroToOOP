using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an instance of a Cat
            //must input the information for the field
            // the blank one is the default
            Cat cat1 = new Cat();
            Cat cat2 = new Cat("Auggie", "grey", 4, 10, true, true);

            cat1.Name = "gato";
            cat1.FurColor = "black";

            //prints the Cat's names to the console.
            Console.WriteLine(cat1.Name);
            Console.WriteLine(cat2.Name);
            Console.WriteLine((cat1.FurColor + cat1.Name));
            
        }
    }
}
