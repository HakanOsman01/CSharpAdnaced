using System;

namespace _05._Generic_Count_Method_Strings
{
    public class Program
    {
        static void Main(string[] args)
        {
            ComparebleObjects<string>objects= new ComparebleObjects<string>();
            int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string currentValue= Console.ReadLine();
                objects.List.Add(currentValue);
            }
            string element=Console.ReadLine();
            int countBiggesValues = objects.CompareTo(element);
            Console.WriteLine(countBiggesValues);
        }
    }
}