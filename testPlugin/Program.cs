using Exercises;

namespace testPlugin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }


    public class SamplePlugin : IPlugin
    {
        public void Execute()
        {

        }

        public string GetText()
        {
            return "SamplePlugin from SamplePlugin";
        }
    }
}