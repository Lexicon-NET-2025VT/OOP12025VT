namespace OOP12025VT;

internal class Program
{
    static void Main(string[] args)
    {
        var cat = new Cat();
        var dog = new Dog(10.0);

        var animals = new List<Animal> { cat, dog };
        foreach (var animal in animals)
        {
            var lunch = new Dog(1);
            animal.Eat(lunch);
            Console.WriteLine(animal);
        }
    }
}

abstract class Animal
{
    public double Weight { get; set; }

    public Animal(double weight)
    {
        Weight = weight;
        MakeSound();
    }

    public virtual void Eat(Animal lunch)
    {
        Weight += lunch.Weight;
    }

    public override string ToString()
    {
        return $"Weight: {Weight}";
    }

    public abstract void MakeSound();
}

class Cat : Animal
{
    public double PurrVolume { get; }

    public Cat() : base(4.5)
    {
        PurrVolume = Weight * 0.5;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, PurrVolume: {PurrVolume}";
    }

    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}

class Dog : Animal
{
    public Dog(double weight) : base(weight)
    {
    }

    public override void Eat(Animal lunch)
    {
        Weight += lunch.Weight * 0.8;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Woff!");
    }
}