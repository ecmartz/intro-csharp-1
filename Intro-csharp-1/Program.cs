using System;

    class Program
    {
        static void Main()
        {
            // 2 Board types in C#
            /*
             * Value types = int, float, double, structs, enum, etc.
             * Reference types = Interface, Class, delegates, arrays, etc.
             * 
             * string is actually a Class
             * 
             * Value Types cannot hold null values, they are defaulted to "zero"
             *     Nullable Value Types
             *     Non-nullable Value Types
             * 
             * Reference Types default to NULL
             * 
             * Explicit conversion
             *      .Value returns a non-nullable counterpart
             *      Cast operator nullable to non-nullable
             */

            string name = null;

            // Make a Value Type nullable
            int? i = null;

            // Say you want an optional "Are you Major" field which evaluates to T/F, but the user doesn't give a response
            bool? areyoumajor = null;

            if (areyoumajor == true)                     // If value exists, use areyoumajor.Value
            {
                Console.WriteLine("User is Major");
            }
            else if (areyoumajor == false)                 // If value exists, use !areyoumajor.Value
            {
                Console.WriteLine("User is not Major");
            }
            else
            {
                Console.WriteLine("User abstain");
            }

            /* Converting from nullable to non-nullable */
            int? ticketsonsale = 100;

            int availabletickets;

            if(ticketsonsale == null)
            {
                availabletickets = 0;
            }
            else
            {
                // availabletickets = ticketsonsale.Value;      Return non-nullable counterpart
                availabletickets = (int)ticketsonsale;          // Cast operator usage
            }

            Console.WriteLine("AvailableTickets = {0}", availabletickets);

            /* Null coalescing operator */
            int? ticketsonsale2 = null;

            int availabletickets2 = ticketsonsale2 ?? 0;

            Console.WriteLine("After null coalescing: AvailableTickets2 = {0}", availabletickets2);

        }
    }
