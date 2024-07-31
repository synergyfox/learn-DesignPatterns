using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory
{
    public class Suzuki : Car   
    {
        public string GetCarModel()
        {
            return "Wagon R";
        }
        public int GetCarPrice()
        {
            return 3400000;
        }
        public int GetCarMileage()
        {
            return 20;
        }
    }
}
