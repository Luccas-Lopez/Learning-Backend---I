﻿using System;

namespace exercise_five
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Tabuada do {i}");
                for (int c = 1; c <= 10; c++)
                {
                    Console.WriteLine($"{i}x{c} = {i * c}");
                }
            }
        }
    }
}
