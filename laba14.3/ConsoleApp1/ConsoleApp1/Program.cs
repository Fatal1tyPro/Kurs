using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public class EmptyStringException : Exception
        {
            public EmptyStringException() : base("Строка не может быть пустой") { }
        }

        public class MyClass
        {
            public void MyMethod(string str)
            {
                if (string.IsNullOrEmpty(str))
                    throw new EmptyStringException();
            }
        }

        class Program1
        {
            static void Main(string[] args)
            {
                try
                {
                    var myClass = new MyClass();
                    myClass.MyMethod("");
                }
                catch (EmptyStringException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

    }
}
