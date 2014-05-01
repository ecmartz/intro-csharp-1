using System;

    class Program
    {
        static void Main()
        {
            /* PART 8
             * Arrays
             * 
             * Pros: Arrays are strongly typed
             * Cons: Arrays cannot grow in size once initialized. Have to rely on integral indices to retrieve items from array.
             */

            int[] evennumbers = new int[3];

            evennumbers[0] = 0;
            evennumbers[1] = 2;
            evennumbers[2] = 4;
            evennumbers[3] = 6;

            Console.WriteLine(evennumbers[1]);
        }
    }
