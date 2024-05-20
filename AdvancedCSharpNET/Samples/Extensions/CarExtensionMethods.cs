using System;
using AdvancedCSharp.Samples.Class;
using AdvancedCSharp.Samples.Class.Inheritance;

namespace AdvancedCSharp.Samples.Extensions
{
    public static class CarExtensionMethods
    {
        public static void WorkHard(this Bulldozer bulldozer)
        {
            while (!bulldozer.IsServiceCheckNeeded())
            {
                bulldozer.DoSomeWork();
            }
        }

        public static void DriveTwice(this Car car)
        {
            car.Drive(100);

            car = new Car(10);

            car.Drive(100);



            var c1 = new Car(5);
            c1.DriveTwice();
            Console.WriteLine(car.Distance); ;
        }


        public static string WorkHard(this Bulldozer bulldozer, int times)
        {
            while (!bulldozer.IsServiceCheckNeeded() && times > 0)
            {
                bulldozer.DoSomeWork();
                times--;
            }

            return "Work completed";
        }
    }
}
