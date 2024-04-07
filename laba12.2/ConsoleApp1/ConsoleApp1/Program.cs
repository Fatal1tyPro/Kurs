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
            public enum Gender
        {
            Male,
            Female
        }

        public class Person : IComparable<Person>
        {
            public int Age { get; set; }
            public Gender Gender { get; set; }

            public int CompareTo(Person other)
            {
                // Девушки перед мужчинами
                if (Gender != other.Gender)
                {
                    return Gender == Gender.Female ? -1 : 1;
                }

                // Возраст в порядке возрастания
                return Age.CompareTo(other.Age);
            }
        }

        public class PersonComparer : IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {
                // Девушки перед мужчинами
                if (x.Gender != y.Gender)
                {
                    return x.Gender == Gender.Female ? -1 : 1;
                }

                // Возраст в порядке возрастания
                return x.Age.CompareTo(y.Age);
            }
        }

        public class MobileNetwork
        {
            // ...
        }

        public class MobilePhone<T> where T : MobileNetwork
        {
            public T Network { get; set; }
        }

        public void Run()
        {
            List<Person> listOfPerson = new List<Person>();
            // Добавьте 10 человек, 5 девушек, 5 мужчин
            // ...

            // Сортировка с помощью IComparable
            listOfPerson.Sort();

            // Сортировка с помощью IComparer
            listOfPerson.Sort(new PersonComparer());

            MobilePhone<MobileNetwork> phone = new MobilePhone<MobileNetwork>();
            // ...
        }

    }
}

