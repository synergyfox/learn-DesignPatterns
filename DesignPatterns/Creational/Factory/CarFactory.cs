using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory
{
    /*
     The Factory Method Design Pattern provides an interface for creating objects in a superclass 
        but allows subclasses to alter the type of objects that will be created.
        This pattern is useful when a class cannot anticipate the class of objects
        it must create or when subclasses want to specify the objects it creates. 
     */



    public abstract class CarFactory
    {
        protected abstract Car CreateCar();
        //concrete method
        public Car getCarObject()
        {
            Car car = this.CreateCar();
            return car;
        }
    }

    public class ToyotaFactory : CarFactory
    {
        protected override Car CreateCar()
        {
            Car car = new Toyota();
            return car;
        }
    }

    public class SuzukiFactory : CarFactory
    {
        protected override Car CreateCar()
        {
            Car car = new Suzuki();
            return car;
        }
    }
}
