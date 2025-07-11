using System;

namespace OOPPrinciples.Abstraction
{
    // Abstraction is the concept of hiding complex implementation details and showing only the necessary features of an object.
    // An abstract class cannot be instantiated and is used as a base for other classes.
    // The 'Shape' class is abstract. It has an abstract method 'Area()' which has no implementation.
    // Any class that inherits from Shape, like Circle or Rectangle, must provide an implementation for the Area() method.
    public abstract class Shape
    {
        public abstract double Area(); // Abstract method

        public void Display()
        {
            Console.WriteLine("This is a shape.");
        }
    }

    // The Circle class inherits from the abstract Shape class.
    public class Circle : Shape
    {
        private double radius;

        // Constructor for the Circle class.
        public Circle(double radius)
        {
            this.radius = radius;
        }

        // This is the implementation of the abstract 'Area' method for a Circle.
        // The 'override' keyword is used to provide an implementation for an abstract method from the base class.
        public override double Area()
        {
            return Math.PI * radius * radius;
        }
    }

    // The Rectangle class also inherits from the abstract Shape class.
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        // Constructor for the Rectangle class.
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        // This is the implementation of the abstract 'Area' method for a Rectangle.
        public override double Area()
        {
            return width * height;
        }
    }
} 