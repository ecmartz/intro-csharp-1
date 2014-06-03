using System;

    class Program
    {
        static void Main()
        {
            /*
             * PART 13: while loop in C#
             * http://youtu.be/5xlc9qzOQmk
             */

            Console.WriteLine("Please enter your target");

            int userTarget = int.Parse(Console.ReadLine());

            int Start = 0;

            while (Start <= userTarget)
            {
                // Newlines
                Console.WriteLine(Start);
                // Concat spaces
                Console.Write(Start + " ");
                Start = Start + 2;
            }
        }
    }
