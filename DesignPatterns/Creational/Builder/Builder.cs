using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{

    /**
     * 
     * The Builder Design Pattern builds a complex object
     * using many simple objects and a step-by-step approach. 
     * The Process of constructing the complex object should be so generic 
     * that the same construction process can be used to create different
     * representations of the same complex object.
    **/
    public class Beverage
    {
        public int Water { get; set; }
        public int Milk { get; set; }
        public int Sugar { get; set; }
        public int PowderQuantity { get; set; }
        public string BeverageName { get; set; }

        public string ShowBeverage()
        {
            return "Hot " + BeverageName + " [" + Water + " ml of water, " + Milk + "ml of milk, " + Sugar
                            + " gm of sugar, " + PowderQuantity + " gm of " + BeverageName + "]\n";
        }
    }

    
    #region Abstract Builder    
    public abstract class BeverageBuilder
    {
        protected Beverage beverage;

        public Beverage GetBeverage()
        {
            return beverage;
        }

        public void CreateBeverage()
        {
            beverage = new Beverage();
        }

        public abstract void SetBeverageType();
        public abstract void SetWater();
        public abstract void SetMilk();
        public abstract void SetSugar();
        public abstract void SetPowderQuantity();
    }
    #endregion

    #region Concrete Builder    
    public class CoffeeBuilder : BeverageBuilder
    {
        public override void SetWater()
        {
            Console.WriteLine("Step 1 : Boiling water");
            GetBeverage().Water = 40;
        }
        public override void SetMilk()
        {
            Console.WriteLine("Step 2 : Adding milk");
            GetBeverage().Milk = 50;
        }
        public override void SetSugar()
        {
            Console.WriteLine("Step 3 : Adding Sugar");
            GetBeverage().Sugar = 10;
        }
        public override void SetPowderQuantity()
        {
            Console.WriteLine("Step 4 : Adding 15 Grams of coffee powder");
            GetBeverage().PowderQuantity = 15;
        }
        public override void SetBeverageType()
        {
            Console.WriteLine("Coffee");
            GetBeverage().BeverageName = "Coffee";
        }
    }

    public class TeaBuilder : BeverageBuilder
    {
        public override void SetWater()
        {
            Console.WriteLine("Step 1 : Boiling water");
            GetBeverage().Water = 50;
        }
        public override void SetMilk()
        {
            Console.WriteLine("Step 2 : Adding milk");
            GetBeverage().Milk = 60;
        }
        public override void SetSugar()
        {
            Console.WriteLine("Step 3 : Adding Sugar");
            GetBeverage().Sugar = 10;
        }
        public override void SetPowderQuantity()
        {
            Console.WriteLine("Step 4 : Adding 5 Grams of tea powder");
            GetBeverage().PowderQuantity = 5;
        }
        public override void SetBeverageType()
        {
            Console.WriteLine("Tea");
            GetBeverage().BeverageName = "Tea";
        }
    }
    #endregion

    #region Director
    public class BeverageDirector
    { 
        public Beverage MakeBeverage (BeverageBuilder beverageBuilder)
        {        
                beverageBuilder.CreateBeverage();
                beverageBuilder.SetBeverageType();
                beverageBuilder.SetWater();
                beverageBuilder.SetMilk();
                beverageBuilder.SetSugar();
                beverageBuilder.SetPowderQuantity();
                return beverageBuilder.GetBeverage();        
        }    
    }
    #endregion
}
