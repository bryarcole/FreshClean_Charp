using System;
using System.Collections.Generic;
using OOPPrinciples.Encapsulation;
using OOPPrinciples.Abstraction;
using OOPPrinciples.Inheritance;
using OOPPrinciples.Polymorphism;

namespace OOPPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program demonstrates the four main principles of Object-Oriented Programming (OOP).\\n");

            // 1. Encapsulation
            Console.WriteLine("--- 1. Encapsulation ---");
            Console.WriteLine("Encapsulation is demonstrated with a 'Car' class.");
            Console.WriteLine("The car's internal state (like whether the engine is running) is hidden and can only be changed via public methods.\\n");
            
            // Create a new instance of the Car class.
            Car myCar = new Car("Toyota", "Camry");
            // Call a public method to get the car's information. We can't access the private fields directly.
            Console.WriteLine(myCar.GetCarInfo());
            // Call a public method to change the car's internal state.
            myCar.StartEngine();
            // Get the information again to see the change.
            Console.WriteLine(myCar.GetCarInfo());
            // Call another public method.
            myCar.StopEngine();
            Console.WriteLine(myCar.GetCarInfo());
            
            Console.WriteLine("\\n--------------------------------\\n");

            // 2. Abstraction
            Console.WriteLine("--- 2. Abstraction ---");
            Console.WriteLine("Abstraction is shown with a 'Shape' abstract class, and 'Circle' and 'Rectangle' concrete classes.");
            Console.WriteLine("We can't create a 'Shape' object, but we can create objects of the classes that inherit from it.\\n");

            // We declare variables of type 'Shape', but instantiate them with concrete classes 'Circle' and 'Rectangle'.
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);

            // Call the Area() method on both objects. Each object knows how to calculate its own area.
            Console.WriteLine($"Circle Area: {circle.Area()}");
            Console.WriteLine($"Rectangle Area: {rectangle.Area()}");

            Console.WriteLine("\\n--------------------------------\\n");

            // 3. Inheritance
            Console.WriteLine("--- 3. Inheritance ---");
            Console.WriteLine("Inheritance is demonstrated with an 'Animal' base class and 'Dog' and 'Cat' derived classes.");
            Console.WriteLine("The 'Dog' and 'Cat' classes inherit properties and methods from 'Animal'.\\n");

            // Create an instance of the Dog class. We need to set the 'Name' because it is a 'required' property.
            Dog myDog = new Dog { Name = "Buddy" };
            // Call the 'Eat' method, which is inherited from the Animal class.
            myDog.Eat();
            // Call the 'Bark' method, which is specific to the Dog class.
            myDog.Bark();

            // Create an instance of the Cat class.
            Cat myCat = new Cat { Name = "Whiskers" };
            // It also has the 'Eat' method.
            myCat.Eat();
            // And its own specific method, 'Purr'.
            myCat.Purr();

            Console.WriteLine("\\n--------------------------------\\n");

            // 4. Polymorphism
            Console.WriteLine("--- 4. Polymorphism ---");
            Console.WriteLine("Polymorphism allows objects of different classes to be treated as objects of a common parent class.");
            Console.WriteLine("Here, both 'Dog' and 'Cat' are treated as 'Animal's, but their 'MakeSound' method behaves differently.\\n");
            
            // Create a Dog and a Cat, but store them in variables of type Animal.
            // This is possible because both Dog and Cat *are* Animals (due to inheritance).
            Animal anotherDog = new Dog { Name = "Rocky" };
            Animal anotherCat = new Cat { Name = "Luna" };

            // Call the 'MakeSound' method on both.
            // Even though both variables are of type 'Animal', the program calls the correct 'override'n method from Dog and Cat.
            // This is polymorphism in action.
            anotherDog.MakeSound();
            anotherCat.MakeSound();

            Console.WriteLine("\\n--------------------------------\\n");

            // 4a. Polymorphism with Interfaces
            Console.WriteLine("--- 4a. Polymorphism with Interfaces ---");
            Console.WriteLine("Here's another example of polymorphism using an interface called 'IMovable'.");
            Console.WriteLine("Both 'Person' and 'Automobile' can 'Move', but they do it differently.\\n");

            // Create a list that can hold any object that implements the IMovable interface.
            var movables = new List<IMovable>
            {
                new Person { Name = "Alice" },
                new Automobile { Type = "Sedan" }
            };

            // Loop through the list and call the Move() method on each object.
            // This works even though the objects are of different concrete types (Person, Automobile).
            foreach (var movable in movables)
            {
                movable.Move();
            }
            
            Console.WriteLine("\\n--------------------------------\\n");
            
            Console.WriteLine("Demonstration finished. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
