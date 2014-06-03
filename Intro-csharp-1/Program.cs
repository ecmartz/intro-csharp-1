using System;

    class Program
    {
        public static void Main()
        {
            /*
             * PART 20: Static and instance class members
             * http://youtu.be/cFQLmHCguGs
             * Static class members
             * Instance class members
             *  their differences
             * 
             * 'this' refers to the current instance of the object
             * static constructors cannot have access modifiers
             * Class members w/o access modifiers are implied 'private'
             * 
             * Static class constructors are used to initialize static fields
             * Static constructors are initialized before istance constructors
             *  and even before you refer to any field in that class!
             */

            Circle C1 = new Circle(5);
            float area = C1.calculateArea();
            Console.WriteLine("Area = {0}", area);

            Circle C2 = new Circle(6);
            float area2 = C2.calculateArea();
            Console.WriteLine("Area = {0}", area2);
        }
    }

class Circle
{
    //static float _PI = 3.141F;  // Single shared copy of _PI for all instances
    // float _PI = 3.141F;        // Copy of _PI for each instance of Circle
    static float _PI;
    int _radius;

    static Circle()
    {
        Console.WriteLine("Static constructor called");
        Circle._PI = 3.141F;
    }

    public Circle(int radius)
    {
        Console.WriteLine("Instance constructor called");
        this._radius = radius;
    }

    public float calculateArea()
    {
        return Circle._PI * this._radius * this._radius;
    }
}