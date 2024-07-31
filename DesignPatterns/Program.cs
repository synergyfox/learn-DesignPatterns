#define Factory  // Pattern
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

Car car  = new ToyotaFactory().Manufacture();
Console.WriteLine("Car Model (Toyota): " + car.GetCarModel());
Console.WriteLine("Car Price (Toyota): " + car.GetCarPrice());
Console.WriteLine("Car Milage (Toyota): " + car.GetCarMileage());

Car carSuzu = new SuzukiFactory().Manufacture();
Console.WriteLine("Car Model (Suzuki): " + carSuzu.GetCarModel());
Console.WriteLine("Car Price (Suzuki): " + carSuzu.GetCarPrice());
Console.WriteLine("Car Milage (Suzuki): " + carSuzu.GetCarMileage());

Console.ReadLine();

#endif //Factory ends
#endregion// CreationalPatterns ends
#endif