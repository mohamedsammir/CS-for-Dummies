﻿using System;

namespace Chapter_13_Solution_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string dictionary = ".NET - platform for applications from Microsoft\nCLR - managed execution environment for .NET\nnamespace - hierarchical organization of classes\n";
            foreach (string str in tempDictionary)
            {
                if (str.Contains(input)) Console.WriteLine(str.Substring(input.Length));
            }
                Console.ReadLine();
        }
    }
}