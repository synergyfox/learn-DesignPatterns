#define ProxyPattern  // Pattern
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

EmployeeAdapterClass employeeAdapterClass = new EmployeeAdapterClass();
employeeAdapterClass.ProcessCompanySalary(employeesArray);


#endif

#if BridgePattern

using DesignPatterns.Structural.BridgePattern;

PersistenceImplementor filePersistenceImplementor = new FilePersistenceImplementor();
filePersistenceImplementor.SaveData("File Data");
filePersistenceImplementor.DeleteData(1);
filePersistenceImplementor.UpdateData(1, "File Data");


PersistenceImplementor databasePersistenceImplementor = new DatabasePersistenceImplementor();
databasePersistenceImplementor.SaveData("Database Data");
databasePersistenceImplementor.DeleteData(1);   
databasePersistenceImplementor.UpdateData(1, "Database Data");


#endif

#if CompositePattern



using DesignPatterns.Structural.CompositePattern;

//Leaf Objects
IComponent hardDrive = new Leaf("Hard Drive", 2000);
IComponent ram = new Leaf("RAM", 3000);
IComponent cpu = new Leaf("CPU", 5000);
IComponent mouse = new Leaf("Mouse", 1000);
IComponent keyboard = new Leaf("Keyboard", 1000);

//Composite Objects

Composite motherBoard = new Composite("Motherboard");
Composite cabinet = new Composite("Cabinet");
Composite peripherals = new Composite("Peripheral");
Composite computer = new Composite("Computer");

motherBoard.AddComponent(cpu);
motherBoard.AddComponent(ram);
cabinet.AddComponent(motherBoard);
cabinet.AddComponent(hardDrive);

peripherals.AddComponent(mouse);
peripherals.AddComponent(keyboard);

computer.AddComponent(cabinet);
computer.AddComponent(peripherals);

Console.WriteLine("Pirce of Computer Composite Components");
computer.DisplayPrice();

Console.WriteLine("Pirce of Cabinet Composite Components");
cabinet.DisplayPrice();

Console.WriteLine("Pirce of Peripherals Composite Components");
peripherals.DisplayPrice();


#endif

#if DecoratorPattern

using DesignPatterns.Structural.Decorator;
ICar bmwCar1 = new BMWCar();
bmwCar1.ManufactureCar();
Console.WriteLine(bmwCar1 + "\n");

DieselCarDecorator carWithDieselEngine = new DieselCarDecorator(bmwCar1);
carWithDieselEngine.ManufactureCar();
Console.WriteLine();


ICar bmwCar2 = new BMWCar();
PetrolCarDecorator carWithPetrolEngine = new PetrolCarDecorator(bmwCar2);
carWithPetrolEngine.ManufactureCar();


#endif

#if FacadePattern
using DesignPatterns.Structural.Facade;

Order order = new Order();
order.PlaceOrder();
#endif

#if FlyweightPattern

using DesignPatterns.Structural.Flyweight;
Console.WriteLine("\n Red color Circles ");
for (int i = 0; i < 3; i++)
{
    Circle circle = (Circle)ShapeFactory.GetShape("circle");
    circle.SetColor("Red");
    circle.Draw();
}

Console.WriteLine("\n Green color Circles ");
for (int i = 0; i < 3; i++)
{
    Circle circle = (Circle)ShapeFactory.GetShape("circle");
    circle.SetColor("Green");
    circle.Draw();
}

Console.WriteLine("\n Blue color Circles");
for (int i = 0; i < 3; ++i)
{
    Circle circle = (Circle)ShapeFactory.GetShape("circle");
    circle.SetColor("Blue");
    circle.Draw();
}
Console.WriteLine("\n Orange color Circles");
for (int i = 0; i < 3; ++i)
{
    Circle circle = (Circle)ShapeFactory.GetShape("circle");
    circle.SetColor("Orange");
    circle.Draw();
}

//Creating Circle Objects with Black Color
Console.WriteLine("\n Black color Circles");
for (int i = 0; i < 3; ++i)
{
    Circle circle = (Circle)ShapeFactory.GetShape("circle");
    circle.SetColor("Black");
    circle.Draw();
}

#endif

#if ProxyPattern
using DesignPatterns.Structural.Proxy;

Console.WriteLine("Client passing employee with Role Developer to folderproxy");
Employee emp1 = new Employee("haseeb", "123", "Developer");
SharedFolderProxy folderProxy1 = new SharedFolderProxy(emp1);
folderProxy1.PerformReadWrite();
Console.WriteLine();
Console.WriteLine("Client passing employee with Role Manager to folderproxy");
Employee emp2 = new Employee("arsalan", "123", "Manager");
SharedFolderProxy folderProxy2 = new SharedFolderProxy(emp2);
folderProxy2.PerformReadWrite();

#endif


#endif //StructualPatterns ends