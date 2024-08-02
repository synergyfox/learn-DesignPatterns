#define AbstractFactory  // Pattern
#define CreationalPatterns  //Category

#if CreationalPatterns
#region CreationalPatterns
#if Singleton
using DesignPatterns.Creational;
using DesignPatterns.Creational.Factory;
Singleton seniorBodyBuilder = Singleton.GetInstance();
seniorBodyBuilder.Canlift("Max 120 KG");

Singleton juniorBodyBuilder = Singleton.GetInstance();
juniorBodyBuilder.Canlift("Max 60 KG");

Singleton starterBodyBuilder = Singleton.GetInstance();
starterBodyBuilder.Canlift("Max 10 KG");
#endif //Singleton ends


#if Factory
using DesignPatterns.Creational.Factory;

Car car  = new ToyotaFactory().getCarObject();
Console.WriteLine("Car Model (Toyota): " + car.GetCarModel());
Console.WriteLine("Car Price (Toyota): " + car.GetCarPrice());
Console.WriteLine("Car Milage (Toyota): " + car.GetCarMileage());

Car carSuzu = new SuzukiFactory().getCarObject();
Console.WriteLine("Car Model (Suzuki): " + carSuzu.GetCarModel());
Console.WriteLine("Car Price (Suzuki): " + carSuzu.GetCarPrice());
Console.WriteLine("Car Milage (Suzuki): " + carSuzu.GetCarMileage());

Console.ReadLine();

#endif //Factory ends

#if AbstractFactory

using DesignPatterns.Creational.Abstract_Factory;

IFoodFactory junkfoodFactory    = new JunkFoodFactory();
junkfoodFactory.CreateFood().GetCalories();
junkfoodFactory.CreateFood().IsGoodForHealth();
junkfoodFactory.CreateFoodSource().BuyFrom();
Console.WriteLine("--------------------------------------------------------------------------");
IFoodFactory healthyfoodFactory = new HealthyFoodFactory();
healthyfoodFactory.CreateFood().GetCalories();
healthyfoodFactory.CreateFood().IsGoodForHealth();
healthyfoodFactory.CreateFoodSource().BuyFrom();
Console.ReadLine();

#endif

#endregion// CreationalPatterns ends
#endif