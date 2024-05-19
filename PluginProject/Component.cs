using System;
using Common;

namespace PluginProject
{
    public class Component : IComponent
    {
        public void Execute()
        {
            Console.WriteLine("Component class from PluginProject executes.");
        }

        public bool IsLicensed()
        {
           return new LicenceManager().IsLicensed();
        }
    }
}
