using System;

namespace JimiPractice
{
    public class JimiPracticeNew
    {
        static void Main()
        {
           
           var numbers = new int[7] {8, 16, 2, 5, 99, 60, 70};
            numbers[4] = 26;
            numbers[3] = numbers[6];
            numbers[2] = numbers[2] + 2;

            bool[] boolArray = new bool[3] { true, false, false };
            Console.WriteLine(8); Console.WriteLine(16); Console.WriteLine(boolArray);
        }
    }
}
