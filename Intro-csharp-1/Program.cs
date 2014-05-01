using System;

    class Program
    {
        static void Main()
        {
            // Assignment operator
            int i = 10;
            bool b = true;

            // Quotient and modulo operator
            int numerator = 10;
            int denominator = 2;

            int result = numerator / denominator;
            int result2 = numerator % denominator;

            Console.WriteLine("Quotient = {0}", result);
            Console.WriteLine("Remainder = {0}", result2);

         
            int number = 10;
            int anothernumber = 20;

            // Comparison operator
            if(number == 10)
            {
                Console.WriteLine("number is 10");
            }

            // AND comparison operator
            if(number == 10 && anothernumber == 20)
            {
                Console.WriteLine("number is 10 AND anothernumber is 20");
            }

            // Program control flow
            bool isnumber10;

            if(number == 10)
            {
                isnumber10 = true;
            }
            else
            {
                isnumber10 = false;
            }

            Console.WriteLine("number == 10 is {0}", isnumber10);

            // Ternary operator
            bool isnum10 = number == 10 ? true : false;
            Console.WriteLine("Ternary: number == 10 is {0}", isnum10);
        }
    }
