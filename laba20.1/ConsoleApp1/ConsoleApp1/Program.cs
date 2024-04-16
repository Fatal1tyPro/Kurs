using System;
using System.IO;
using System.Reflection;

namespace PluginLoader
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string pluginDirectory = "Plugins";
           
            string pluginFileName = "Plugin.dll";

            
            string pluginPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, pluginDirectory, pluginFileName);

            
            if (File.Exists(pluginPath))
            {
                try
                {
                    
                    Assembly pluginAssembly = Assembly.LoadFrom(pluginPath);
                    
                    Type pluginType = pluginAssembly.GetType("Plugin.Plugin");
                    
                    object pluginInstance = Activator.CreateInstance(pluginType);
                    
                    MethodInfo runLogicMethod = pluginType.GetMethod("RunLogic");
                    
                    runLogicMethod.Invoke(pluginInstance, null);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при загрузке и выполнении плагина: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Плагин не найден.");
            }
        }
    }
}

namespace Plugin
{
    public class Plugin
    {
        public void RunLogic()
        {
            Console.WriteLine("Логика выполнения из плагина.");
        }
    }
}
