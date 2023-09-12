using System;

namespace _05._Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parser = p => int.Parse(p);
            int[]numbers=Console.ReadLine()
            .Split(" ",StringSplitOptions.RemoveEmptyEntries)
            .Select(parser)
            .ToArray();
            string command=Console.ReadLine();
            Func<int, int[]> addOneNumber =  num=>
            {
                
               for (int i = 0; i <numbers.Length ; i++) 
               {
                    numbers[i] += num;
               }
               return numbers;
            };
            Func<int, int[]> multiply = m =>
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i]*= m;
                }
                return numbers;

            };
            Func<int, int[]> substract = sub =>
            {
                for(int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] -= sub;
                }
                return numbers;
            };
            Action<int[]> print = p =>
            { Console.WriteLine($"{string.Join(" ", numbers)}");};
            while (command!= "end")
            {
                if(command== "add")
                {
                    numbers = AddOne(numbers, addOneNumber);
                }
                else if(command== "multiply")
                {
                    numbers=MultiplyByTwo(numbers, multiply);
                }
                else if(command== "subtract")
                {
                    numbers=SubstactByOne(numbers, substract);
                }
                else
                {
                    print(numbers);
                }
                command = Console.ReadLine();
            }
        }
        public static int[] AddOne(int[] numbers, Func<int, int[]>func)
        {
            return func(1);
        }
        public static int[]MultiplyByTwo(int[] numbers, Func<int, int[]> func)
        {
            return func(2);
        }
        public static int[] SubstactByOne(int[] numbers, Func<int, int[]> func)
        {
            return func(1);
        }
       
    }
}