﻿using System;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("what is your name?");
            string name;
            name = Console.ReadLine();
            Console.WriteLine("hello " + name);
            Console.ReadLine();
        }
    }
}