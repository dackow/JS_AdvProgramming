using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesNET
{
    public class Singleton
    {
        private static Singleton instance ;

        private Singleton() { }

        public CultureInfo Language { get; set; }


        public static Singleton Instance 
        {
            get 
            {
                instance ??= new Singleton();

                return instance;
            }
        }

        //public static Singleton GetInstance()
        //{

        //}
    }
}
