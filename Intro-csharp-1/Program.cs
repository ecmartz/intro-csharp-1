using System;

    class Program
    {
        static void Main()
        {
            /*
             * PART 11: Switch statements
             * 
             */

            Console.WriteLine("Please enter a number");
            int usernum = int.Parse(Console.ReadLine());

            switch(usernum)
            {
                case 10:
                    Console.WriteLine("Your number is 10.");
                    break;
                case 20:
                    Console.WriteLine("Your number is 20.");
                    break;
                case 30:
                    Console.WriteLine("Your number is 30.");
                    break;
                default:
                    Console.WriteLine("Your number is not 10, 20, or 30.");
                    break;
            }

            Console.WriteLine("Next part");

            switch(usernum)
            {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("Your number is {0}", usernum);
                    break;
                default:
                    Console.WriteLine("Your number is not 10, 20, or 30.");
                    break;
            }
        }
    }
