using System;

namespace GenericsProblem
{
    public class IntegerMaximum
    {
        public void FindIntNum(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                Console.WriteLine("a is max");
            }
            if (b >= a && b >= c)
            {
                Console.WriteLine("b is max");
            }
            else
            {
                Console.WriteLine("c is max");
            }

        }

        public void FindFloatNum(float a, float b, float c)
        {
            if (a > b && a > c)
            {
                Console.WriteLine("a is max");
            }
            if (b > a && b > c)
            {
                Console.WriteLine("b is max");
            }
            else
            {
                Console.WriteLine("c is max");
            }

        }
       


    }
}
