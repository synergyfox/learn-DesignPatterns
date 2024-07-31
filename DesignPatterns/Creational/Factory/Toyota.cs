using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory
{
    public class Toyota :Car
    {
        public string GetCarModel()
        {
            return "Toyota GLI";
        }
        public int GetCarPrice()
        {
            return 6700000;
        }
        public int GetCarMileage()
        {
            return 15;
        }
    }
}
