using System;

    class Program
    {
        public static void Main()
        {
            /*
             * PART 17: Method parameters
             * http://youtu.be/c4hOXIG8yPo
             */

            /* Parameters (4 types)
             * Value parameters         : Passes a copy
             * Reference parameters     : with the 'ref' keyword, passes the reference
             * Out parameters           : Return more than one value using 'out' keyword
             * Parameter arrrays        : Lets you pass a variable amount of params using 'params' keyword
             */

            /* Arguments    : values that are passed in the invoking call
             * Parameters  :  values that are passed in the method declaration
             */

            int i = 0;
            int total, product;
            int[] nums = new int[3];

            nums[0] = 101;
            nums[1] = 102;
            nums[2] = 103;

            simpleMethod(i);                        // Pass by value
            Console.WriteLine(i);

            simpMethod(ref i);                      // Pass by references
            Console.WriteLine(i);

            calcUlate(10, 20, out total, out product); // Multiple outputs

            paramsMethod(nums);                     // Parameter array

            Console.WriteLine("Sum = {0} && Product = {1}", total, product);
        }

        /* Value parameter usage */
        public static void simpleMethod(int j)      // Pass by value
        {
            j = 101;
        }

        /* Reference parameter usage */
        public static void simpMethod(ref int j)    // Pass by reference
        {
            j = 101;
        }

        /* Out parameter usage */
        public static void calcUlate(int fn, int sn, out int sum, out int product) // Returning multiple values
        {
            sum = fn + sn;
            product = fn * sn;

        }

        /* Parameter array usage */
        public static void paramsMethod(params int[] nums) // Essentially makes parameter arrays optional
        {
            Console.WriteLine("There are {0} elements.",nums.Length);
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
        }
    }
