using System;
using System.IO;
using System.Threading.Channels;

namespace AdvancedCSharp.Samples.Delegates
{
   
    internal class DelegateOverview
    {
        public delegate int IntOperation(int x, int y);

        private static Action<int, int> _action;
        static void Main()
        {
            var a = 3;
            var b = 2;


            IntOperation op = (x, y) =>
            {
                Console.WriteLine("a = " + a);
                Console.WriteLine("b = " + b);
                return x + y;
            };

            DoSomething(op, (str) => { Console.WriteLine(str); }) ;


            IntOperation operation = (x, y) => { Console.WriteLine("add"); return x + y; };
            //var operation = new IntOperation((x, y) => { return x - y; });  //or this
            operation = Func;                    //or this

            var ret = operation.Invoke(a,b); //sum
            Console.WriteLine("Sum on {0} and {1} is {2}", a,b, ret);

            operation = (x, y) => { Console.WriteLine("sub"); return x - y; };
            ret = operation.Invoke(a, b); //subtraction
            Console.WriteLine("Subtraction on {0} and {1} is {2}", a, b, ret);

            operation = (x, y) => { Console.WriteLine("prod"); return x * y; }; //what about += events
            ret = operation.Invoke(a, b); //product
            Console.WriteLine("Product on {0} and {1} is {2}", a, b, ret);


            //Action<string>

            /*
             * Action  void Foo()
             * Action<T,U> void Foo(T a, U b) 
             * 
             * Func<R> R Foo()
             * 
             * Func<T, U> U Foo(T a)
             * 
             * 
             * Func<Action<string>, List<int>>    List<int> Foo(Action<string> str)
             */

            Func<int, int, int> func = Func;//new Func<int, int, int>(operation);
            Action<int, int> action = ((x, y) =>
            {
                Console.WriteLine(ret);
                Console.WriteLine(operation(x, y));
            });
            _action = action;
            _action(4, 5); //_action.Invoke(4, 5);
            Console.ReadKey();
        }

        private static int Func(int arg1, int arg2)
        {
            throw new NotImplementedException();
        }

        //int vs int? Nullable<int>
        //object vs object?
        public static void DoSomething(IntOperation? myDelegate, Action<string> logger)
        {
            ///
            ///
            if (myDelegate != null)
            {
                var ret = myDelegate(1, 2);
            }

            myDelegate?.Invoke(1, 2);
            logger("wykonano myDelegate");
            
            // Console.WriteLine("wykonano myDelegate");
            //File.AppendAllText("", "wykonano myDelegate");


            var retAsync = myDelegate.BeginInvoke(1, 2, null, null);


            var result = myDelegate.EndInvoke(retAsync);
        }
    }
}
