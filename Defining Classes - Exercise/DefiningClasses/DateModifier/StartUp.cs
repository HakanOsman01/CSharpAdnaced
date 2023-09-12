using System;
using System.Runtime.CompilerServices;

namespace DateModifier
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string firstDate=Console.ReadLine();
            string secondDate=Console.ReadLine();
            Console.WriteLine(DateModifier.DateDiffrence(firstDate,secondDate));

        }
    }
}