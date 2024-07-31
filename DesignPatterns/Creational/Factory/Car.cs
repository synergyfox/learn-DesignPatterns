using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory
{
    public interface Car
    {
        string GetCarModel();
        int GetCarPrice();
        int GetCarMileage();

    }
}
