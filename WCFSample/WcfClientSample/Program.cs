using ServiceReference1;
using System.ServiceModel;

namespace WcfClientSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var client = new ShapeTransformationClient(new BasicHttpBinding(), new EndpointAddress("http://localhost:8888/RectangleTransform"));

            var r = client.GetRectangleAsync(2, 3).Result;
            client.ChangeSize(r, 2);

            Console.WriteLine($"Rectangle width:{r.Width} height:{r.Height}");
        }
    }
}