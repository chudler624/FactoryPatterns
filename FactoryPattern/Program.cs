using FactoryPattern;

Console.WriteLine("How many wheels does your vehicle have?");
var numberOfWheels= int.Parse(Console.ReadLine());

var answer = VehicleFactory.GetVehicle(numberOfWheels);
Console.WriteLine($"Congratulations on your {answer.Year} {answer.Make} {answer.Model}");