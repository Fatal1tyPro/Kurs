using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class laba8
    {

// Задание 1: Класс Item
public class Item
    {
        private string Name { get; set; } = "unknown";

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }
    }

    // Задание 2: Классы Engine и Transport
    public class Engine
    {
        public void Start()
        {
            Console.WriteLine("Engine started.");
        }
    }

    public abstract class Transport
    {
        protected Engine Engine { get; set; }

        public abstract void Move();
    }

    public class Car : Transport
    {
        public Car()
        {
            Engine = new Engine();
        }

        public override void Move()
        {
            Engine.Start();
            Console.WriteLine("Car is moving.");
        }
    }

    public class Plane : Transport
    {
        public Plane()
        {
            Engine = new Engine();
        }

        public override void Move()
        {
            Engine.Start();
            Console.WriteLine("Plane is flying.");
        }
    }

    // Задание 3: Метод расширения для массива int
    public static class ArrayExtensions
    {
        public static int Max(this int[] array)
        {
            int max = int.MinValue;
            foreach (int num in array)
            {
                if (num > max)
                    max = num;
            }
            return max;
        }
    }

    // Задание 4: Класс Bag
    public class Bag
    {
        private Item[] items = new Item[8];
        private bool _isOpen;

        public void ToggleOpen()
        {
            _isOpen = !_isOpen;
        }

        public void AddItem(Item item)
        {
            if (!_isOpen)
                return;

            bool bagFull = true;
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == null)
                {
                    items[i] = item;
                    bagFull = false;
                    Console.WriteLine($"Item with name '{item.GetName()}' added to the bag.");
                    break;
                }
            }

            if (bagFull)
                Console.WriteLine("The bag is full.");
        }

        public Item RemoveItem(int index)
        {
            if (!_isOpen)
            {
                Console.WriteLine("The bag is closed.");
                return null;
            }

            if (index < 0 || index >= items.Length || items[index] == null)
            {
                Console.WriteLine("No item found at the specified index.");
                return null;
            }

            Item item = items[index];
            items[index] = null;
            Console.WriteLine($"Item '{item.GetName()}' removed from the bag.");
            return item;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Пример использования созданных классов и методов
            Item item1 = new Item();
            item1.SetName("Book");

            Item item2 = new Item();
            item2.SetName("Laptop");

            Console.WriteLine($"Item 1 name: {item1.GetName()}");
            Console.WriteLine($"Item 2 name: {item2.GetName()}");

            Car car = new Car();
            car.Move();

            Plane plane = new Plane();
            plane.Move();

            int[] numbers = { 1, 8, 3, 7, 2 };
            int maxNumber = numbers.Max();
            Console.WriteLine($"Max number in the array: {maxNumber}");

            Bag bag = new Bag();
            bag.ToggleOpen();
            bag.AddItem(item1);
            bag.AddItem(item2);
            bag.RemoveItem(0);
        }
    }

}
}
