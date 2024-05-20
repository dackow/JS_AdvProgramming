using System;

namespace Exercises.Delegates.Sample.Delegates
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

        private readonly Action _usages;
        private readonly Func<int> _speedLimit;

        public Car(string name, Action countCarUsages, Func<int> speedLimitFunc)
        {
            _usages = countCarUsages;
            _speedLimit = speedLimitFunc;
            Name = name;
        }

        public void Drive()
        {
            _usages();
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


        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }


        public CarFactory()
        {
            TotalUsageCount = 0;
            MaxSpeedLimit = 80;
        }

        public Car CreateCar(string carName)
        {
            return new Car(carName, () => TotalUsageCount++, () => MaxSpeedLimit);
        }
    }
}
