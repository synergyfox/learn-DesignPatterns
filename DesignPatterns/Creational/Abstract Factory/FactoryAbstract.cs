using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Abstract_Factory
{

    /**
     * According to the Gang of Four Definition, The Abstract Factory Design Pattern provides a way
     * to encapsulate a group of factories with a common theme without specifying their concrete classes.
     * Abstract means hiding some information, factory means which produces the products, and pattern
     * means a design. So, the Abstract Factory Pattern is a software design pattern that provides a way
     * to encapsulate a group of individual factories that have a common theme.
     * In simple words, the Abstract Factory is a super factory that creates other factories.
     * It is also called the Factory of Factories. The Abstract Factory design pattern provides an 
     * interface for creating families of related or dependent products but leaves the actual object
     * creation to the concrete factory classes.
     * **/

    #region Abstract Products
    public interface IFood
    {
        void IsGoodForHealth();
        void GetCalories();
        
    }

    public interface IFoodSource
    {        
        void BuyFrom();
    }

    #endregion
    #region ConcreteProducts

    public class MightyZinger : IFood
    {
        public void GetCalories()
        {
            Console.WriteLine("---MightyZinger: 1028 calories in 1 sandwich (399 g)\n");
        }

        public void IsGoodForHealth()
        {
            Console.WriteLine("--MightyZinger Not Good For Health. Unless you do workout\r\n");
        }
    }
    public class ZingerBurgerSource : IFoodSource
    {
        public void BuyFrom()
        {
            Console.WriteLine("----Buy From KFC,Macdonalds,King Burger\r\n");
        }
    }
    public class FruitSalad : IFood
    {
        public void GetCalories()
        {
            Console.WriteLine("---Fruit Salad  24.2g total carbs, 20.9g net carbs, 0.3g fat, 1g protein, and 93 calories\r\n");
        }

        public void IsGoodForHealth()
        {
            Console.WriteLine("--FruitSalad Good For Health.\r\n");
        }
    }
    public class FruitSaladSource : IFoodSource
    {
        public void BuyFrom()
        {
            Console.WriteLine("--Buy From Vegitable Shop\r\n");
        }
    }
    #endregion
    #region Abstract Factory

    public interface IFoodFactory
    {
        IFood CreateFood();
        IFoodSource CreateFoodSource();
    }



    #endregion
    #region Concrete Factory

    public class JunkFoodFactory : IFoodFactory
    {
        public IFood CreateFood()
        {
            return new MightyZinger();
        }

        public IFoodSource CreateFoodSource()
        {
          return new ZingerBurgerSource();
        }
    }
    public class HealthyFoodFactory : IFoodFactory
    {
        public IFood CreateFood()
        {
            return new FruitSalad();
        }

        public IFoodSource CreateFoodSource()
        {
            return new FruitSaladSource();
        }
    }


    #endregion
}
