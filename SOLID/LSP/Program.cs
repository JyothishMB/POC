// See https://aka.ms/new-console-template for more information
//using LSP.Problem.Problem1;
using LSP.Solution.Solution1;

//Apple apple = new Apple();
//Console.WriteLine(apple.GetColor());

//Apple apple = new Orange();
//Console.WriteLine(apple.GetColor());

//If S is a subtype of T, 
//then objects of type T should be replaced with the objects of type S.

IEnumerable<Fruit> fruits = new List<Fruit>()
{
    new Apple(),
    new Orange()
};

foreach(Fruit f in fruits)
{
    Console.WriteLine(f.GetColor());
}