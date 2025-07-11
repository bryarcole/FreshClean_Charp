using System;

namespace OOPPrinciples.Inheritance
{
    // Inheritance allows a new class (derived class) to inherit properties and methods from an existing class (base class).
    // This promotes code reuse.
    // The 'Dog' and 'Cat' classes inherit from the 'Animal' class.
    // They automatically have the 'Eat()' method and 'Name' property from 'Animal'.
    //
    // Polymorphism is demonstrated with the 'MakeSound()' method. It is declared as 'virtual' in the base class 'Animal'
    // and 'override'n in the derived classes 'Dog' and 'Cat'. This allows objects of 'Dog' and 'Cat' to be treated
    // as objects of 'Animal', but still invoke their own specific 'MakeSound()' implementation.
    public class Animal
    {
        // A property to store the animal's name. 'required' means it must be set when an object is created.
        public required string Name { get; set; }

        // A method that all animals share.
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        // A 'virtual' method can be overridden by derived classes.
        // This provides a default implementation that can be changed by a more specific class like Dog or Cat.
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} makes a sound.");
        }
    }

    // The Dog class inherits from Animal. This means a Dog is an Animal.
    // It gets the Name property and the Eat() method from Animal automatically.
    public class Dog : Animal
    {
        // A method specific to the Dog class.
        public void Bark()
        {
            Console.WriteLine($"{Name} is barking.");
        }

        // Here, we 'override' the MakeSound method to provide a Dog-specific implementation.
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} barks.");
        }
    }

    // The Cat class also inherits from Animal.
    public class Cat : Animal
    {
        // A method specific to the Cat class.
        public void Purr()
        {
            Console.WriteLine($"{Name} is purring.");
        }

        // The Cat class also overrides the MakeSound method for a Cat-specific sound.
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} meows.");
        }
    }
} 