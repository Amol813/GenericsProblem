using System;

namespace GenericsProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Three Integers Max program!");

            IntegerMaximum integerMaximum = new IntegerMaximum();


            Console.WriteLine(" Case 1:");
            integerMaximum.FindIntNum(50, 15, 9);


            Console.WriteLine(" Case 2:");
            integerMaximum.FindIntNum(15, 50, 9);


            Console.WriteLine(" Case 3:");
            integerMaximum.FindIntNum(15, 9, 50);

            Console.ReadLine();
        }
    }
}