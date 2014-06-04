using System;

    class Program
    {
        public static void Main()
        {
            /*
             * PART 21: Inheritance
             * http://youtu.be/OLTk0xAVY00
             * 
             * Inheritance syntax,
             * derived class : base class
             * 
             * FOUR PILLARS OF OOP
             * 1. Inheritance
             * 2. Encapsulation
             * 3. Abstraction
             * 4. Polymorphism
             * 
             * Each class can only have ONE base class
             * C# supports multiple interface inheritance
             * Base classes are automatically instantiated before inherited classes
             * Using base(), you can determine which constructor the child class will run
             * 
             */

            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.firstName = "Joe";
            FTE.lastName = "Blowe";
            FTE.yearlySalary = 50000;
            FTE.printFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.firstName = "Joel";
            PTE.lastName = "Blow";
            PTE.hourlyRate = 10;
            PTE.printFullName();

            ChildClass CC = new ChildClass();
        }
    }

public class Employee
{
    public string firstName;
    public string lastName;
    public string email;

    public void printFullName()
    {
        Console.WriteLine(firstName + " " + lastName);
    }
}

public class FullTimeEmployee : Employee
{
    public float yearlySalary;
}

public class PartTimeEmployee : Employee
{
    public float hourlyRate;
}

public class ParentClass
{
    public ParentClass()
    {
        Console.WriteLine("Parent Constructor called.");
    }
    public ParentClass(string message)
    {
        Console.WriteLine(message);
    }
}

public class ChildClass : ParentClass
{
    public ChildClass() : base("Derived class controlling Parent class")
    {
        Console.WriteLine("Child Constructor called.");
    }
}