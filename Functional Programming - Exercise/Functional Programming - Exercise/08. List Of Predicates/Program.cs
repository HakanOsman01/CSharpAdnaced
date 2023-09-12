using System;
using System.Linq;

namespace _08._List_Of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {

       
            int range=int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine()
           .Split(' ', StringSplitOptions.RemoveEmptyEntries)
           .Select(int.Parse)
           .ToArray();
            Func<int[], HashSet<int>> getUniqueNumbers = array =>
            {
                HashSet<int>set= new HashSet<int>();
                foreach (int curNumber in array)
                {
                    set.Add(curNumber);
                }
                return set;
            };
            HashSet<int> set =GetTheUniquesNumbers(numbers, getUniqueNumbers);
            Func<int,HashSet<int>, List<int>> getDivisibleNumbers = (num,set) =>
            {
                bool isDivisible=true;
                List<int> list= new List<int>();
                for (int i = 1; i <=num; i++)
                {
                    foreach(int currentNumber in set)
                    {
                        if (i % currentNumber != 0)
                        {
                            isDivisible = false;

                        }
                      
                    }
                    if (isDivisible)
                    {
                        list.Add(i);
                    }
                    isDivisible = true;
                }
                return list;
            };
            List<int> list = GetDivisibleNumbers(range, set, getDivisibleNumbers);
            Console.WriteLine($"{string.Join(" ",list)}");

        }
        static HashSet<int> GetTheUniquesNumbers(int[] numbers, Func<int[], HashSet<int>> unique)
        {
            return unique(numbers);
        }
        static List<int> GetDivisibleNumbers(int number,HashSet<int>numbers, Func<int, HashSet<int>, List<int>>divisons)
        {
            List<int>result=divisons(number,numbers);
            return result;
        }
    }
}