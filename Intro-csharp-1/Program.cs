using System;

    class Program
    {
        static void Main()
        {
            // Escape sequence
            string sassyname = "\"Esteban\"";
            Console.WriteLine(sassyname);

            // Newline charcters
            string newline = "one\ntwo\nthree";
            Console.WriteLine(newline);

            // Verbatim Literal
            string verbatim = @"C:\REPOS\Intro-csharp-1\";
            Console.WriteLine(verbatim);
        }
    }
