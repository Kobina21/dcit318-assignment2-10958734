using System;

namespace InheritanceDemo
{
    // Base class Animal with method MakeSound()
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class Dog that overrides MakeSound()
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class Cat that overrides MakeSound()
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Inheritance and Method Overriding Demo ===\n");

            // Create instances of Animal, Dog, and Cat
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            // Call MakeSound() on each instance
            Console.WriteLine("Animal sound:");
            animal.MakeSound();

            Console.WriteLine("\nDog sound:");
            dog.MakeSound();

            Console.WriteLine("\nCat sound:");
            cat.MakeSound();

            // Demonstrate polymorphism with base class references
            Console.WriteLine("\n=== Polymorphism Demo ===");
            Animal[] animals = new Animal[]
            {
                new Animal(),
                new Dog(),
                new Cat(),
                new Dog(),
                new Cat()
            };

            for (int i = 0; i < animals.Length; i++)
            {
                string animalType = animals[i] is Dog ? "Dog" : 
                                  animals[i] is Cat ? "Cat" : "Animal";
                Console.Write($"Animal {i + 1} ({animalType}): ");
                animals[i].MakeSound();
            }

            // Demonstrate method hiding vs overriding
            Console.WriteLine("\n=== Method Hiding vs Overriding Demo ===");
            Animal animalAsBase = new Dog(); // Dog treated as Animal
            Dog dogAsDog = new Dog();        // Dog treated as Dog

            Console.WriteLine("Dog treated as Animal (polymorphism):");
            animalAsBase.MakeSound();

            Console.WriteLine("\nDog treated as Dog:");
            dogAsDog.MakeSound();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
