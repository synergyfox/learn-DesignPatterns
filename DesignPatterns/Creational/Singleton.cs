using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational
{
    /*** The Singleton Design Pattern is a Creational Design Pattern used to ensure that 
    a class has only one instance and provides a global point of access to it.In C#, 
    the Singleton Design Pattern is useful when 
    we need exactly one instance of a class to coordinate actions across the system.***/

    public sealed class Singleton
    {
        private static int Counter = 0;
        private static Singleton instance = null;
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();

            }
            return instance;

        }


        //Constructor
        private Singleton()
        {
            Counter++;
            Console.WriteLine("Total Objects Created " + Counter.ToString());
        }

        public void Canlift(string printMsg)
        {
            Console.WriteLine(printMsg);
        }

    }
}
