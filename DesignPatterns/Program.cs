﻿#define State  // Pattern
#define BehavioralPattern  //Category

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


#if BehavioralPattern
#if ChainofResponsibilityPattern

using DesignPatterns.Behavioral.ChainOfResponsibility;

ATM atm = new ATM();
Console.WriteLine("Requested Amount = 8600 Rs");
atm.Withdraw(8600);

Console.WriteLine("Requested Amount = 3600 Rs");
atm.Withdraw(3600);

Console.WriteLine("Requested Amount = 600 Rs");
atm.Withdraw(600);


Console.WriteLine("Requested Amount = 500 Rs");
atm.Withdraw(500);

Console.WriteLine("Requested Amount = 100 Rs");
atm.Withdraw(100);


#endif

#if CommandPattern
using DesignPatterns.Behavioral.Command;

Document document = new Document();

ICommand openCommand = new OpenCommand(document);   
ICommand saveCommand = new SaveCommand(document);   
ICommand closeCommand = new CloseCommand(document); 

MenuOptions menuOptions = new MenuOptions(openCommand,saveCommand,closeCommand);
menuOptions.ClickSave();
menuOptions.ClickOpen();
menuOptions.ClickClose();
#endif


#if IntrepreterPattern

using DesignPatterns.Behavioral.Interpreter;

List<IExpression> objExpressions = new List<IExpression>();
Context context = new Context(DateTime.Now);
Console.WriteLine("Please Select the Expression  : MM DD YYYY or YYYY MM DD or DD MM YYYY ");
context.Expression = Console.ReadLine();
string[] strExpressions = context.Expression.Split(' ');
foreach (string str in strExpressions)
{
    if (str == "DD")
    {
        objExpressions.Add(new DayExpression());
    }
    else if (str == "MM")
    {
        objExpressions.Add(new MonthExpression());
    }
    else if (str == "YYYY")
    {
        objExpressions.Add(new YearExpression());
    }
    else
    {
        objExpressions.Add(new SeparatorExpression());
    }
}
objExpressions.Add(new SeparatorExpression());
foreach (IExpression obj in objExpressions)
{
    obj.Evaluate(context);
}
Console.WriteLine( context.Expression) ;



#endif

#if IteratorPattern

using DesignPatterns.Behavioral.Iterator;

EmlployeesCollection collection = new EmlployeesCollection();
collection.AddEmployee(new Employee("Asad", 100));
collection.AddEmployee(new Employee("Rizwan", 101));
collection.AddEmployee(new Employee("Osama", 102));
collection.AddEmployee(new Employee("Ali", 103));
collection.AddEmployee(new Employee("Ahmed", 104));
collection.AddEmployee(new Employee("Bashir", 105));

Iterator iterator = collection.CreateIterator();
Console.WriteLine("Iterating over collection:");
for (Employee emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
{
    Console.WriteLine($"ID : {emp.ID} & Name : {emp.Name}");
}
#endif

#if MediatorPattern

using DesignPatterns.Behavioral.Mediator;

IChatGroupMediator chatMediator = new ChatGroupMediator();

User Asad = new ConcreteUser("Asad");
User Zain = new ConcreteUser("Zain");
User Osama = new ConcreteUser("Osama");
User Hamza = new ConcreteUser("Hamza");

chatMediator.RegisterUser(Asad);
chatMediator.RegisterUser(Zain);
chatMediator.RegisterUser(Osama);
chatMediator.RegisterUser(Hamza);

Asad.Send("This is a test for Mediator Pattern");
Osama.Send("This is a second test message");

#endif

#if ObserverPattern

using DesignPatterns.Behavioral.Observer;

Subject RedMI = new Subject("Red MI Mobile", 10000, "Out Of Stock");
Observer user1 = new Observer("Basit");
user1.AddSubscriber(RedMI);
Observer user2 = new Observer("Ali");
user2.AddSubscriber(RedMI);

Console.WriteLine("Red MI Mobile current state : " + RedMI.GetAvailability());
user2.RemoveSubscriber(RedMI);
RedMI.SetAvailability("Available");

#endif

#if Memento

using DesignPatterns.Behavioral.Memento;

Originator originator = new Originator();
originator.employee = new Employee("1", "Ali", "10000", "Developer");

Caretaker caretaker = new Caretaker();
Memento memento = originator.CreateMemento();
caretaker.AddMemento(memento);

originator.employee = new Employee("2", "Ali", "20000", "Sr. Developer");
memento = originator.CreateMemento();
caretaker.AddMemento(memento);

Console.WriteLine("\nOrignator Current State : " + originator.GetDetails());
Console.WriteLine("\nOriginator Restoring to Developer");
originator.SetMemento(caretaker.GetMemento(0));
Console.WriteLine("\nOrignator Current State : " + originator.GetDetails());


#endif

#if Strategy

using DesignPatterns.Behavioral.Strategy;

ICompression strategy = new ZipCompression();
CompressionContext ctx = new CompressionContext(strategy);
ctx.CreateArchive("Installer");

ctx.SetStrategy(new RarCompression());
ctx.CreateArchive("Installer");


#endif

#if State
using DesignPatterns.Behavioral.State;

ATMMachine atmMachine = new ATMMachine();
Console.WriteLine($"ATM Machine Current state : {atmMachine.AtmMachineState.GetType().Name}");
Console.WriteLine();
atmMachine.EnterPin();
atmMachine.WithdrawMoney();
atmMachine.EjectDebitCard();
atmMachine.InsertDebitCard();



Console.WriteLine($"ATM Machine Current state : {atmMachine.AtmMachineState.GetType().Name}");
Console.WriteLine();
atmMachine.EnterPin();
atmMachine.WithdrawMoney();
atmMachine.InsertDebitCard();
atmMachine.EjectDebitCard();


Console.WriteLine("");

Console.WriteLine($"ATM Machine Current state : {atmMachine.AtmMachineState.GetType().Name}");

#endif


#endif // End BehavioralPattern