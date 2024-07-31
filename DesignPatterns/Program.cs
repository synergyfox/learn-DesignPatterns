#region Singleton
using DesignPatterns.Creational;
Singleton seniorBodyBuilder = Singleton.GetInstance();
seniorBodyBuilder.Canlift("Max 120 KG");

Singleton juniorBodyBuilder = Singleton.GetInstance();
juniorBodyBuilder.Canlift("Max 60 KG");

Singleton starterBodyBuilder = Singleton.GetInstance();
starterBodyBuilder.Canlift("Max 10 KG");

Console.ReadLine();
#endregion

