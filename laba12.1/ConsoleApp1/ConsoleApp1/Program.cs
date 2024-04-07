using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
            public interface IAnimal
        {
            string Name { get; set; }
        }

        public interface ICarnivore : IAnimal { }

        public interface IHerbivore : IAnimal { }

        public class Elephant : IHerbivore, IEquatable<Elephant>
        {
            public string Name { get; set; }
            public int Size { get; set; }

            public bool Equals(Elephant other)
            {
                if (other == null) return false;
                return this.Size == other.Size;
            }
        }

        public class Zoo
        {
            private List<ICarnivore> Carnivores = new List<ICarnivore>();
            private List<IHerbivore> Herbivores = new List<IHerbivore>();

            public void AddAnimal(IAnimal animal)
            {
                switch (animal)
                {
                    case ICarnivore carnivore:
                        Carnivores.Add(carnivore);
                        break;

                    case IHerbivore herbivore:
                        Herbivores.Add(herbivore);
                        break;

                    default:
                        throw new Exception("Unknown animal type");
                }
            }
        }

    }
}

