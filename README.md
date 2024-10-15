# Baby Class Project

This project implements a simple `Baby` class in C#. The class demonstrates the use of constructors and properties to represent a baby with attributes like birth date, first name, and last name.

## Features

- Two constructors:
  - **Default Constructor:** Initializes a `Baby` object with the current date as the birth date and prints "Ingaaaa" to the console.
  - **Alternative Constructor:** Initializes a `Baby` object with specified first and last names, sets the birth date to the current date, and prints "Ingaaaa" to the console.

## Usage

To use the `Baby` class, simply create instances of it using either constructor. Below is a brief example:

```csharp
class Program
{
    static void Main()
    {
        // Creating a baby using the Default Constructor
        Bebek bebek =  new Bebek();
        Console.WriteLine($"Bebegin adi : {bebek.Name} Soyadi : {bebek.Surname} Dogum gunu : {bebek.Birthday}");

        // Creating a baby using the Alternative Constructor
        Bebek newBebek = new Bebek("Yavuz","Gecimli");
        Console.WriteLine($"Bebegin adi : {newBebek.Name} Soyadi : {newBebek.Surname} Dogum gunu : {newBebek.Birthday}");
    }
}
