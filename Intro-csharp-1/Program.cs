using System;

    class Program
    {
        static void Main()
        {
            /*
             * PART 14: do while loop in C#
             * http://youtu.be/s7fVZZeNXec
             */

            // Do while always execute at least once!

            string userChoice = string.Empty;
            do
            {
                Console.WriteLine("Enter your target");
                int userTarget = int.Parse(Console.ReadLine());

                int start = 0;

                while (start <= userTarget)
                {
                    Console.Write(start + " ");
                    start = start + 2;
                }

                do
                {
                    Console.WriteLine("Would you like to continue? (Y/N)");
                    userChoice = Console.ReadLine().ToUpper();
                    if (userChoice != "Y" && userChoice != "N")
                    {
                        Console.WriteLine("Invalid choice.");
                    }

                } while (userChoice != "Y" && userChoice != "N");
            } while (userChoice == "Y");
        }
    }
