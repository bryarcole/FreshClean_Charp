using System;

namespace OOPPrinciples.Polymorphism
{
    // Polymorphism can also be achieved using interfaces.
    // An interface defines a "contract" of what a class can do, without specifying how it does it.
    // Any class or struct that implements this interface must provide an implementation for all its members.
    public interface IMovable
    {
        void Move(); // A method that any "movable" object should have.
    }

    // The Person class implements the IMovable interface.
    public class Person : IMovable
    {
        public required string Name { get; set; }

        // This is the Person's implementation of the Move method.
        public void Move()
        {
            Console.WriteLine($"{Name} is walking.");
        }
    }

    // The Automobile class also implements the IMovable interface.
    public class Automobile : IMovable
    {
        public required string Type { get; set; }

        // This is the Automobile's implementation of the Move method.
        public void Move()
        {
            Console.WriteLine($"The {Type} is driving.");
        }
    }
} 