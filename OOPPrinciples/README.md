# C# OOP Principles Demonstration

This project is a simple C# console application designed to demonstrate the four fundamental principles of Object-Oriented Programming (OOP) for beginners.

The four principles are:
1.  **Encapsulation**
2.  **Abstraction**
3.  **Inheritance**
4.  **Polymorphism**

Each principle is explained with code examples in its own dedicated file.

## Getting Started

### Prerequisites

*   [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later.

### How to Run the Project

1.  Clone this repository or download the source code.
2.  Open a terminal or command prompt.
3.  Navigate to the `OOPPrinciples` directory.
4.  Run the following command:

    ```bash
    dotnet run
    ```

The program will execute and print a demonstration of each OOP principle to the console.

## Exploring the Code

### 1. Encapsulation (`Encapsulation.cs`)

**Concept:** Encapsulation is about bundling data (attributes) and the methods that operate on that data into a single unit, or "class." It also involves hiding the internal state of an object from the outside world and only exposing what is necessary.

**Example:** The `Car` class demonstrates this. The `make`, `model`, and `isEngineStarted` fields are `private`, meaning they cannot be accessed directly from outside the `Car` class. Instead, you must use public methods like `StartEngine()` and `GetCarInfo()` to interact with the car's state. This prevents accidental or improper modification of the car's data.

### 2. Abstraction (`Abstraction.cs`)

**Concept:** Abstraction means hiding complex implementation details and showing only the essential features of an object. In C#, this is often achieved with `abstract` classes and `interfaces`.

**Example:** The `Shape` class is an `abstract` class. It declares that any `Shape` must have an `Area()` method, but it doesn't know *how* to calculate it. The concrete classes `Circle` and `Rectangle` inherit from `Shape` and provide their own specific implementations of the `Area()` method. You can't create a `Shape` object itself, only objects of its more specific, concrete subclasses.

### 3. Inheritance (`Inheritance.cs`)

**Concept:** Inheritance allows a new class (a "derived" or "child" class) to inherit properties and methods from an existing class (a "base" or "parent" class). This promotes code reuse.

**Example:** The `Dog` and `Cat` classes both inherit from the `Animal` class. This means they automatically get the `Name` property and the `Eat()` method without having to redefine them. They are also free to add their own specific methods, like `Bark()` for the `Dog` and `Purr()` for the `Cat`.

### 4. Polymorphism (`Inheritance.cs` and `Polymorphism.cs`)

**Concept:** Polymorphism, which means "many forms," allows objects of different classes to be treated as objects of a common parent class or interface. The same method can be called on these different objects, and each will respond in its own way.

**Example 1 (Class-based):** In `Inheritance.cs`, the `Animal` class has a `virtual MakeSound()` method. Both `Dog` and `Cat` `override` this method. In `Program.cs`, we can treat a `Dog` object and a `Cat` object as `Animal`s. When we call `MakeSound()` on them, the program is smart enough to execute the correct version—the dog barks, and the cat meows.

**Example 2 (Interface-based):** In `Polymorphism.cs`, we define an `IMovable` interface with a `Move()` method. The `Person` and `Automobile` classes both implement this interface. This means they both have a `Move()` method, but their implementations are different. In `Program.cs`, we can put both a `Person` and an `Automobile` into the same list of `IMovable` objects and call `Move()` on each one, demonstrating polymorphism in a different way. 