using System;

namespace Exercises.Delegates.Sample.Events
{
    class CarFactoryDecoupled
    {
        static void Main()
        {
            var carFactory = new CarFactory();

            var car1 = carFactory.CreateCar("car1");
            var car2 = carFactory.CreateCar("car2");

            car1.Drive();
            car1.Drive();
            car2.Drive();
            carFactory.MaxSpeedLimit = 120;
            car1.Drive();
            car2.Drive();

            Console.WriteLine("Cars were used in total {0} times", carFactory.TotalUsageCount);

            Console.ReadKey();
        }
    }

    class Car
    {
        public string Name { get; private set; }

        private readonly Func<int> _speedLimit;

        public event EventHandler Driven;

        public Car(string name, Func<int> speedLimitFunc)
        {
            _speedLimit = speedLimitFunc;
            Name = name;
        }

        public void Drive()
        {
            Driven?.Invoke(this, new EventArgs());
            AccelerateAndDrive();
        }

        private void AccelerateAndDrive()
        {
            var maxSpeed = _speedLimit();
            Console.WriteLine("{0} speed is {1}", Name, maxSpeed);
        }
    }

    class CarFactory
    {
        public int TotalUsageCount { get; private set; }
        public int MaxSpeedLimit { get; set; }

        public CarFactory()
        {
            TotalUsageCount = 0;
            MaxSpeedLimit = 80;
        }

        public Car CreateCar(string carName)
        {
            var car = new Car(carName, () => MaxSpeedLimit);
            car.Driven += (o, e) => { TotalUsageCount++; };

            return car;
        }
    }
}
