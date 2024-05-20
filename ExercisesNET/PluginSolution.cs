using Exercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesNET
{
    internal class PluginSolution
    {

        static void Main()
        {
            ScanForPlugins();
        }

        private static void ScanForPlugins()
        {
            foreach (var filePath in Directory.GetFiles(".", "*.dll"))
            {
                List<Type> types = new List<Type>();
                Assembly assembly = Assembly.LoadFrom(filePath);
                IEnumerable<Type> assemblyTypes = assembly.GetTypes()
                    .Where(x => x.GetTypeInfo().ImplementedInterfaces.Contains(typeof(IPlugin)) 
                            && x.IsClass);
                types.AddRange(assemblyTypes);

                foreach (var type in types)
                {
                    Console.WriteLine($"Found type: {type.FullName}");

                    var plugin = (IPlugin)assembly.CreateInstance(type.FullName);
                    Console.WriteLine($"GetText() Result: {plugin.GetText()}");
                }
            }
        }
    }
}
