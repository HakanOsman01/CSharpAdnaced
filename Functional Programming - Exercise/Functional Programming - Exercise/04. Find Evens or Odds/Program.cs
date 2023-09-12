using System;

namespace _04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isEvenNumber = num => num % 2 == 0;
            Func<string,int>parser=p=>int.Parse(p);
            int[]range=Console.ReadLine()
            .Split(" ",StringSplitOptions.RemoveEmptyEntries)
            .Select(parser)
            .ToArray();
            int beginRange = range[0];
            int endRange = range[1];
            string condition=Console.ReadLine();
            Action<int,int,string> rangeNumbers = (int begin,
                int end,string c) =>
            {
                for (int cur = begin; cur <= end; cur++)
                {
                    if (c == "even")
                    {
                        if (isEvenNumber(cur))
                        {
                            Console.Write($"{cur} ");
                        }

                    }
                    else
                    {
                        if (!isEvenNumber(cur))
                        {
                            Console.Write($"{cur} ");
                        }

                    }

                }

            };
            rangeNumbers(beginRange,endRange,condition);

        }
    }
}