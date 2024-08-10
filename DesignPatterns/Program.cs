#define AdapterObjectPattern  // Pattern
#define StructualPatterns  //Category

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

#if Prototype

using DesignPatterns.Creational.Prototype;

GymCoach gymCoach = new SeniorGymCoach() {Age=40,ExperienceYears=10, Name="Senior Coach",Salary=40000 };
gymCoach.ShowStats();
GymCoach juniorGymCoach = gymCoach.GetClone();
juniorGymCoach.Name = "Junior Coach";
juniorGymCoach.ExperienceYears = 2;
juniorGymCoach.Age = 25;
juniorGymCoach.ShowStats();

#endif

#if Builder

using DesignPatterns.Creational.Builder;

Beverage beverage = new Beverage();
BeverageDirector beverageDirector = new BeverageDirector();
CoffeeBuilder coffee = new CoffeeBuilder();
beverageDirector.MakeBeverage(coffee);
TeaBuilder tea = new TeaBuilder();
beverageDirector.MakeBeverage(tea);


#endif
#endregion
#endif // CreationalPatterns ends

#if StructualPatterns
#if AdapterObjectPattern

using DesignPatterns.Structural.Adapter;

string[,] employeesArray = new string[5, 4]
           {
                {"101","Qasim","DEV","10000"},
                {"102","Zain","DEV","20000"},
                {"103","Rizwan","DEV","30000"},
                {"104","Hassan","QA","40000"},
                {"105","Madiha","QA","50000"}
           };
Console.WriteLine("HR system passes employee string array to Adapter\n");
ITarget target = new EmployeeAdapter();
target.ProcessCompanySalary(employeesArray);


#endif


#endif //StructualPatterns ends