using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    abstract class Animal
    {
        public abstract string AnimalName { get; set; }

        public Animal(string animalname)
        {
            AnimalName = animalname;
        }

        public abstract void Say();

        public void ShowInfo()
        {
            Console.WriteLine(AnimalName);
            Say();
        }
    }
}
