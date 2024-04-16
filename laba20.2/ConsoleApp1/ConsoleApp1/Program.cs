using System;
using System.Reflection;

namespace CarReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                Assembly carAssembly = Assembly.LoadFrom("Car.dll");

               
                Type carType = carAssembly.GetType("Car.MyCar");

                
                object carInstance = Activator.CreateInstance(carType);

                
                FieldInfo ageField = carType.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);
                ageField.SetValue(carInstance, 6); // 

                
                MethodInfo carMethod = carType.GetMethod("CarMethod", BindingFlags.NonPublic | BindingFlags.Instance);

               
                carMethod.Invoke(carInstance, new object[] { "Hey!" });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
