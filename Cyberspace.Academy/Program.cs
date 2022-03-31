using System;

namespace CLASSWORK
{
    public class Program
    {
        static void Main()
        {
            int x = 9;
            int y = 5;
            Add(x, y);
            Subtract(x, y);
            Divide(x, y);
            Multiply(x, y);
        }

        static void Add(int x, int y)
        {
          
            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
        }
        static void Subtract(int x, int y)
        {
            Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
        }
        static void Divide(int x, int y)
        {
            Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
        }
        static void Multiply(int x, int y)
        {
            Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
        }
    }
}
