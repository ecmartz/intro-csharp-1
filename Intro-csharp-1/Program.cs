using System;

class Customer
{
    string _firstname;
    string _lastname;

    public Customer() : this("No _firstname", "No _lastname") // this() refers to the 2 param class constructor
    { }

    public Customer(string firstName, string lastName)      // Class constructor
    {
        this._firstname = firstName;
        this._lastname = lastName;
    }

    public void printFullName()
    {
        Console.WriteLine("Full name = {0}", _firstname + " " + _lastname);
    }
    
    ~Customer()         // Class destructor, garbage collection
    {
        // Clean up code goes here
    }
}

    class Program
    {
        public static void Main()
        {
            /*
             * PART 19: Intro to classes
             * http://youtu.be/Us2i7D-urgs
             * 
             * Class constructors can help by preventing missing variables.
             * 
             * A constructor is automatically called when an instance of a class is created.
             * Constructors do not have return types.
             * Constructors can be overloaded by the number and type of params.
             */

            Customer C1 = new Customer("Joe", "Blow");      // Customer instantiation
            Customer C2 = new Customer();
            C1.printFullName();
            C2.printFullName();
        }
    }

