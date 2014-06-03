using System;
//using ProjectA.TeamA;         // 'using' directive
//using ProjectA.TeamB;         
//using PATA = ProjectA.TeamA;    // Namespace alias for Team A
//using PATB = ProjectA.TeamB;    // Namespace alias for Team B
using PATA = ProjectA_TeamA;
using PATB = ProjectA_TeamB;

    class Program
    {
        public static void Main()
        {
            /*
             * PART 18: Namespaces
             * http://youtu.be/IQTbvVemMAg
             * 
             * Namespaces help organize program and avoid clashes.
             * Namespaces don't correspond to file, directory or assembly names, they
             * could be written in separate files and/or separate assemblies and still
             * belong to the same namespace.
             * Namespaces can be nested with dot operators and curly brackets
             * 
             * Avoid ambiguity by using fully qualified names!
             */

            Console.WriteLine("Hello");

            PATA.ClassA.print();
            PATB.ClassA.print();
            //ClassA.print(); // if you were using 'using'
            //ProjectA.TeamB.ClassA.print();          // Using all namespaces
            //ProjectA.TeamA.ClassA.print();

            //PATA.ClassA.print();                    // Using namespace aliases
            //PATB.ClassA.print();



            
        }
    }

//namespace ProjectA
//{
//    namespace TeamA
//    {
//        class ClassA
//        {
//            public static void print()
//            {
//                Console.WriteLine("Team A print method");
//            }
//        }
//    }
//}

//namespace ProjectA
//{
//    namespace TeamB
//    {
//        class ClassA
//        {
//            public static void print()
//            {
//                Console.WriteLine("Team B print method");
//            }
//        }
//    }
//}