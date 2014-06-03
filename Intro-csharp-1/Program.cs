using System;

    class Program
    {
        public static void Main()       // Static method
        {
            /*
             * PART 17: Methods
             * http://youtu.be/c4hOXIG8yPo
             */

            // Methods
            // [attributes]
            // access-modifiers return-type method-name ( parameters ) { method body }

            // To invoke an instance method, you have to invoke an instance of that class
            // To invoke a static method, you have to invoke the class

            Program p = new Program();
            p.evenNumbers(50);                  // invoke instance method
            Program.evenNums();                 // invoke static method

            int sum = p.addIt(10, 20);
            Console.WriteLine("Sum = {0}", sum);
            
        }

        public int addIt(int fn, int sn)
        {
            return fn + sn;
        }

        public void evenNumbers(int target)       // Instance method
        {
            int start = 0;

            while (start <= target)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
        }

        public static void evenNums()              // Static method
        {

        }
    }
