using System;

    class Program
    {
        static void Main()
        {
            /* PART 7
             * Datatype Conversion
             * 
             * Implicit/Explicit Conversions
             * Parse(), TryParse()
             * Use Parse() if you are sure the value will be valid
             * Use TryParse() otherwise
             * 
             * Implicit conversions done by the compiler:
             * 1. Implicit conversion is done by the compiler when no loss of information if conversion is done
             * 2. No possibility of throwing exceptions during conversion
             * 
             * Error handling
             * Type cast: Will convert the types willy-nilly
             * Convert Class: Will throw an exception if conversion fails
             */

            // Automagically!
            //int i = 100;
            //float f = i;

            float f = 123.45F;

            int i = (int)f;                         // (int) type cast 
            int j = Convert.ToInt32(f);             // .ToInt32 Convert class

            Console.WriteLine("Type cast: " + i);
            Console.WriteLine("Convert class: {0}", j);


            /* Using Parse() */
            string strnumber = "100";
            int k = int.Parse(strnumber);

            Console.WriteLine("int.Parse = {0}", k);

            /* Using TryParse() */
            string strnum = "12345";
            int result = 0;

            bool isConversionSuccessful = int.TryParse(strnum, out result);

            if (isConversionSuccessful)
                Console.WriteLine(result);
            else
                Console.WriteLine("Please enter a valid number");
        }
    }
