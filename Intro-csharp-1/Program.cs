using System;

    class Program
    {
        static void Main()
        {
            /*
             * PART 12: Switch statements continued
             * 
             */

            int totalcoffeecost = 0;

            Start:
            Console.WriteLine("1. Small\t2. Medium\t3. Large");
            int userchoice = int.Parse(Console.ReadLine());

            switch(userchoice)
            {
                case 1:
                    totalcoffeecost += 1;
                    break;
                case 2:
                    totalcoffeecost += 2;
                    break;
                case 3:
                    totalcoffeecost += 3;
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invalid.", userchoice);
                    goto Start;
            }

            Decide:
            Console.WriteLine("Do you want to buy another coffee? Y or N");
            string userpick = Console.ReadLine();

            switch(userpick.ToUpper())
            {
                case "Y":
                    goto Start;
                case "N":
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invalid. Try again", userpick);
                    goto Decide;
            }

            Console.WriteLine("Thank you for shopping with us");
            Console.WriteLine("Bill amount = {0}", totalcoffeecost);
        }
    }
