using System;

// Интерфейс с методом Eat
interface IEatable
{
    void Eat();
}

// Абстрактный класс Animal с свойством Name
abstract class Animal
{
    public string Name { get; private set; }

    public void SetName(string name)
    {
        Name = name;
    }

    public string GetName()
    {
        return Name;
    }
}

// Класс Dog, реализующий интерфейс IEatable
class Dog : Animal, IEatable
{
    public void Eat()
    {
        Console.WriteLine($"{Name} ест корм.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите имя собаки: ");
        string dogName = Console.ReadLine();

        Dog dog = new Dog();
        dog.SetName(dogName);

        Console.WriteLine($"Имя собаки: {dog.GetName()}");
        ((IEatable)dog).Eat(); // Вызов метода Eat через интерфейс
    }
}
