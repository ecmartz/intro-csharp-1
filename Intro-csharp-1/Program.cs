﻿using System;

    class Program
    {
        static void Main()
        {
            // Booleans can ONLY be EITHER true or false exclusively.
            bool b = true;

            // byte, sbyte, short, ushort, int, uint, long, ulong


            int i = 0;
            Console.WriteLine("Min of int = {0}", int.MinValue);
            Console.WriteLine("Max of int = {0}", int.MaxValue);

            // Double (64-bits)
            double d = 123.456;
            Console.WriteLine(d);

            // Quad (128 bits)
            decimal dec = 654.321m;
        }
    }
