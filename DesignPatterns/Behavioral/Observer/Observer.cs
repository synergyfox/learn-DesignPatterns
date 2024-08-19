using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{



    // The Observer Interface
    public interface IObserver
    {        
        void Update(string availability);
    }

    public class Observer : IObserver
    {
        public string UserName { get; set; }
        public Observer(string userName)
        {
            UserName = userName;
        }
        public void AddSubscriber(ISubject subject)
        {
            subject.RegisterObserver(this);
        }
        public void RemoveSubscriber(ISubject subject)
        {
            subject.RemoveObserver(this);
        }
        public void Update(string availability)
        {
            Console.WriteLine("Hello " + UserName + ", Product is now " + availability + " on Amazon");
        }
    }




    // The Subject Interface
    public interface ISubject
    {        
        void RegisterObserver(IObserver observer);
             
        void RemoveObserver(IObserver observer);
                
        void NotifyObservers();
    }

    //Concrete Subject
    public class Subject : ISubject
    {

        private List<IObserver> observers = new List<IObserver>();

        private string ProductName { get; set; }
        private int ProductPrice { get; set; }
        private string Availability { get; set; }



        public Subject(string productName, int productPrice, string availability)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            Availability = availability;
        }

        public string GetAvailability()
        {
            return Availability;
        }

        public void SetAvailability(string availability)
        {
            this.Availability = availability;
            Console.WriteLine("Availability changed from Out of Stock to Available.");
            NotifyObservers();
        }
        public void NotifyObservers()
        {
            Console.WriteLine("Product Name :"
                           + ProductName + ", product Price : "
                           + ProductPrice + " is Now available. So, notifying all Registered users ");
            Console.WriteLine();
            foreach (IObserver observer in observers)
            {                
                observer.Update(Availability);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            Console.WriteLine("Observer Added : " + ((Observer)observer).UserName);
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            Console.WriteLine("Observer Removed : " + ((Observer)observer).UserName);
            observers.Remove(observer);
        }

    }

}
