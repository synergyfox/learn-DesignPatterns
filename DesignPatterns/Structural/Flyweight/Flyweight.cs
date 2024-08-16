using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight
{
    public interface IShape
    {
        void Draw();
    }

    //Concrete Flyweight 

    public class Circle : IShape
    {
        public string Color { get; set; }   

        private readonly int _x;
        private readonly int _y;
        private readonly int _radius;

        public void SetColor(string color)
        {
            Color = color;
        }   

        public void Draw()
        {
            Console.WriteLine(" Circle: Draw() [Color : " + Color + ", X Cor : " + _x + ", YCor :" + _y + ", Radius :" + _radius);
        }
    }

    //Flyweight Factory 

    public class ShapeFactory
    {
        private static readonly Dictionary<string, IShape> shapeMap = new Dictionary<string, IShape>();

        public static IShape GetShape(string shapeType)
        {
           IShape shape = null;
           if(shapeType.Equals("circle",StringComparison.InvariantCultureIgnoreCase))
            {
                if(shapeMap.TryGetValue("circle", out shape))
                {                  
                }
                else
                {
                    shape = new Circle();
                    shapeMap.Add("circle", shape);                   
                }                
            }
            return shape;
           
        }
    }
}
