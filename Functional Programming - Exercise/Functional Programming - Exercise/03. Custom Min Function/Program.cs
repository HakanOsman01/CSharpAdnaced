using System;

namespace _03._Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int, int> findSmallestNum = (int[] numbers, int minValue) =>
            {

                foreach (int currentNum in numbers)
                {
                    if (minValue >= currentNum)
                    {
                        minValue= currentNum;
                    }
                }
                return minValue;
            };
            Func<string,int>parser = num => int.Parse(num);
            int[]nums=Console.ReadLine()
           .Split(" ",StringSplitOptions.RemoveEmptyEntries)
           .Select(parser)
           .ToArray();
            int minValue = int.MaxValue;
            Console.WriteLine(findSmallestNum(nums,minValue));
        }
    }
}