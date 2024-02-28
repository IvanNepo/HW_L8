namespace HW_L8
{
    internal class Program;

// Абстрактный класс Animal
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

        public abstract void Eat();
    }

    // Класс Dog, наследующий абстрактный класс Animal
    class Dog : Animal
    {
        public override void Eat()
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
            dog.Eat();
        }
    }
}
