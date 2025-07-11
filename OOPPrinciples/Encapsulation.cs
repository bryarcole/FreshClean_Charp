using System;

namespace OOPPrinciples.Encapsulation
{
    // Encapsulation is the bundling of data (attributes) and methods that operate on the data into a single unit or class.
    // It restricts direct access to some of an object's components, which is a key part of data hiding.
    // In this example, make, model, and isEngineStarted are private fields, accessible only within the Car class.
    // Public methods like StartEngine() and GetCarInfo() provide controlled access to this data.
    public class Car
    {
        private string make;
        private string model;
        private bool isEngineStarted;

        // This is the constructor for the Car class. It's a special method called when a new Car object is created.
        // It initializes the car's data (make and model).
        // We use 'this.make' to distinguish the 'make' field of the class from the 'make' parameter of the constructor.
        public Car(string make, string model)
        {
            this.make = make;
            this.model = model;
            this.isEngineStarted = false; // By default, the engine is off.
        }

        // This is a public method to start the car's engine.
        // It includes logic to prevent starting the engine if it's already running.
        public void StartEngine()
        {
            if (!isEngineStarted)
            {
                isEngineStarted = true;
                Console.WriteLine("Engine started.");
            }
            else
            {
                Console.WriteLine("Engine is already running.");
            }
        }

        // This is a public method to stop the car's engine.
        // It includes logic to prevent stopping the engine if it's already off.
        public void StopEngine()
        {
            if (isEngineStarted)
            {
                isEngineStarted = false;
                Console.WriteLine("Engine stopped.");
            }
            else
            {
                Console.WriteLine("Engine is already off.");
            }
        }

        // This method returns a string with the car's current information.
        // It allows us to see the state of the car's private fields without accessing them directly.
        public string GetCarInfo()
        {
            return $"Make: {make}, Model: {model}, Engine Running: {isEngineStarted}";
        }
    }
} 