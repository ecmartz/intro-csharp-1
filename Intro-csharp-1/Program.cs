using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter your name:");

            string username = Console.ReadLine();

            //Console.WriteLine("Hello " + username);   // Concatenation
            Console.WriteLine("Hello {0}", username);   // Place holder syntax
        }
    }
