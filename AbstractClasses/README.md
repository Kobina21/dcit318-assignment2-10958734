# C# Abstract Classes and Methods Demo

This console application demonstrates the use of abstract classes and methods in C#.

## Features

- **Abstract Class**: `Shape` with abstract method `GetArea()`
- **Derived Classes**: 
  - `Circle` - calculates area using π × r²
  - `Rectangle` - calculates area using length × width
- **Polymorphism**: Demonstrates how different shapes can be treated uniformly through the base class

## Project Structure

```
AbstractClassesDemo/
├── Program.cs              # Main application with all classes
├── AbstractClassesDemo.csproj  # Project file
└── README.md              # This file
```

## How to Run

1. Make sure you have .NET 8.0 or later installed
2. Open a terminal in the project directory
3. Run the following commands:

```bash
dotnet restore
dotnet build
dotnet run
```

## Expected Output

The program will display:
- Area calculations for individual Circle and Rectangle instances
- A demonstration of polymorphism using an array of different shapes
- All areas formatted to 2 decimal places

## Key Concepts Demonstrated

1. **Abstract Classes**: The `Shape` class cannot be instantiated directly
2. **Abstract Methods**: `GetArea()` must be implemented by derived classes
3. **Inheritance**: `Circle` and `Rectangle` inherit from `Shape`
4. **Method Overriding**: Each derived class provides its own implementation of `GetArea()`
5. **Polymorphism**: Different shapes can be treated as the same base type
