using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesignPatterns.Structural.CompositePattern
{
    /**
 Component Interface: Define an interface or abstract class for implementing the composites and leaf nodes.
 Leaf: Implement the component interface for the leaf nodes with no children.
 Composite: Implement the component interface and also include a collection of components. The composite object can add, remove, and access the child components.
 Client Code: The client works with all elements through the component interface.
     * 
     * 
     */


    // The base Component class declares common operations for both simple and complex objects of a composition.
    public interface IComponent
    {
        void DisplayPrice();
    }

    // The Leaf class represents the end objects of a composition. A leaf can't have any children.
    public class Leaf : IComponent
    {
        private int Price;
        private string Name;

        public Leaf(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }

        public void DisplayPrice()
        {
            Console.WriteLine($"\tComponent Name: {Name} and Price: {Price}");
        }
    }

    //Composite Class
    // The Composite class represents the complex components that may have children. A composite object can contain both leaves and other composites as children.
    // The Composite objects delegate the actual work to their children and then combine the result.

    public class Composite : IComponent
    {
        public string Name { get; set; }
        List<IComponent> components = new List<IComponent>();

        public Composite(string name)
        {
            this.Name = name;
        }

        public void AddComponent(IComponent component)
        {
            components.Add(component);
        }
        public void DisplayPrice()
        {
            foreach (var item in components)
            {
                item.DisplayPrice();
            }
        }
    }

}
