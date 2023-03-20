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


            Console.WriteLine("Case 2(float):");
            integerMaximum.FindFloatNum(2.5f, 15.5f, 30.5f);



            Console.ReadLine();
        }
    }
}