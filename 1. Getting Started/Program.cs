﻿using System;

namespace dotnetlearning
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Hello, Aleksey Savin!");
            string value = Console.ReadLine();

            while (!value.Equals("exit")) {
                Console.WriteLine("Please, enter some value...");
                value = Console.ReadLine();
            }

            Console.WriteLine("Bye! Bye!");
        } 

    }
}

