using System;

    class Program
    {
        static void Main()
        {
            /*
             * PART 10 If Statements
             * 
             * if(<condition>) { <execute> }
             * else if(<condition>) { <execute> }
             * else { <execute> }
             * 
             * OR:
             * |    Compiler checks both conditions for true
             * ||   Compiler only checks the first condition for true
             * 
             * AND:
             * &    Compiler checks both conditions for false
             * &&   Compiler only checks first condition for false
             * 
             * Doubles are sometimes referred to as "short circuit" operators
             * 
             */

            Console.WriteLine("Please enter a number");
            int usernum = int.Parse(Console.ReadLine());

            if (usernum == 1)
            {
                Console.WriteLine("Your number is 1.");
            }
            else if (usernum == 2)
            {
                Console.WriteLine("Your number is 2.");
            }
            else if (usernum == 3)
            {
                Console.WriteLine("Your number is 3.");
            }
            else
            {
                Console.WriteLine("Your number is not 1,2, or 3.");
            }
        }
    }
