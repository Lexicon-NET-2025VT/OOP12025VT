namespace OOP12025VT;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Animal animal = new Animal(10.0);
    }
}

class Animal
{
    public Animal(double weight)
    {
        Weight = weight;
    }

    public double Weight { get; }
}