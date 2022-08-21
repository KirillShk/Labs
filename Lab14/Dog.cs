using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    internal class Dog : Animal
    {
        private string animalname;

        public override string AnimalName
        {
            get => animalname;
            set => animalname = value;
        }
        public Dog(string animalname) : base(animalname)
        {

        }

        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }
}
