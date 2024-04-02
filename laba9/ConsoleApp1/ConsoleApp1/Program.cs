using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        
            public class Animal
            {
                public virtual void Live()
                {
                    
                }
            }

            public class HerbivoreAnimal : Animal
            {
                public override void Live()
                {
                    EatGrass();
                }

                public void EatGrass()
                {
                    
                }
            }

            public class Predator : Animal
            {
                public bool IsHungry { get; set; }

                public override void Live()
                {
                    if (IsHungry)
                    {
                        Hunt();
                    }
                }

                public void Hunt()
                {
                    
                }
            }

            public class Rabbit : HerbivoreAnimal { }

            public class Deer : HerbivoreAnimal { }

            public class Wolf : Predator { }

            public class Bear : Predator { }

            public class Zoo
            {
                public void AcceptAnimal(Animal animal)
                {
                    if (animal is HerbivoreAnimal)
                    {
                        
                    }
                    else if (animal is Predator)
                    {
                        
                    }
                }
            }

            public static void Main(string[] args)
            {
                
            }
        }
    }
    