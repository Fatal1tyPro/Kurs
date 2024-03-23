using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
        public class ArrayWorker
        {
            public static int[] InvertArray(int[] array)
            {
                int[] invertedArray = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    invertedArray[i] = array[array.Length - 1 - i];
                }
                return invertedArray;
            }
        }

        public class Cone
        {
            private double Radius { get; }
            private double Height { get; }

            public Cone(double radius, double height)
            {
                Radius = radius;
                Height = height;
            }

            public double CalculateBaseArea()
            {
                return Math.PI * Radius * Radius;
            }

            public double CalculateTotalArea()
            {
                double slantHeight = Math.Sqrt(Radius * Radius + Height * Height);
                return Math.PI * Radius * (Radius + slantHeight);
            }
        }

        public class Stack<T>
        {
            private T[] items;
            private int top;

            public Stack(int size)
            {
                items = new T[size];
                top = -1;
            }

            public void Push(T item)
            {
                if (top == items.Length - 1)
                {
                    throw new StackOverflowException("Stack is full");
                }
                items[++top] = item;
            }

            public T Pop()
            {
                if (top == -1)
                {
                    throw new InvalidOperationException("Stack is empty");
                }
                return items[top--];
            }

            public T Peek()
            {
                if (top == -1)
                {
                    throw new InvalidOperationException("Stack is empty");
                }
                return items[top];
            }

            public bool IsEmpty()
            {
                return top == -1;
            }

            public bool IsFull()
            {
                return top == items.Length - 1;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

