﻿using System.Linq;
using System.Threading.Channels;

namespace _04._Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Action<double> addVat = vat => { vat *= 1.20;};
            Func<decimal,string>addVat=x=>(x * 1.2M).ToString("F2");
            Console.WriteLine(string.Join(Environment.NewLine,Console.ReadLine()
            .Split(", ",StringSplitOptions.RemoveEmptyEntries)
            .Select(decimal.Parse)
            .Select(addVat)
            .ToArray()));
        }
    }
}