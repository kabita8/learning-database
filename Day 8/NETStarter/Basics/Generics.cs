using System;
using System.Collections.Generic;
// Define the Generics class within a namespace
namespace MyNamespace
{
    // Remove the public access modifier from the class since top-level statements cannot have access modifiers
    class Generics
    {
        // Define the Print method with a generic type parameter T
        public void Print<T>(T x)
        {
            Console.WriteLine(x);
        }

        // Define the Test method
        public void Test()
        {
            // Correct syntax for creating a list and adding elements to it
             List<int> marks = new List<int> { 21, 34, 50, 12 };
            
            // marks.Add(34);

            // Call the Print method with different data types
            Print<string>("aagf1424");
            Print<decimal>(123.455m); // Specify decimal literal with 'm' suffix
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Generics generics = new Generics();
            generics.Test();
            Console.ReadLine();
        }
    }
}