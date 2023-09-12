using System;
namespace _08._Threeuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            string[] personNameAndAdress = Console.ReadLine()
           .Split(" ", StringSplitOptions.RemoveEmptyEntries)
           .ToArray();
            string personName = personNameAndAdress[0];
            string secondName = personNameAndAdress[1];
            string fullName = personName + " " + secondName;
            string personAddress = personNameAndAdress[2];
            string town = personNameAndAdress[3];
            Threeuple<string, string,string> personAdrees = new Threeuple<string, string,string>();
            personAdrees.AddItems(fullName, personAddress,town);
            Console.WriteLine($"{personAdrees.Item1[0]} -> {personAdrees.Item2[0]} " +
                $"-> {personAdrees.Item3[0]}");
            string[] personNameAndBeer = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
            string personNameBeer = personNameAndBeer[0];
            int beerCount = int.Parse(personNameAndBeer[1]);
            string drunkOrNot = personNameAndBeer[2];
            bool isDrunk = false;
            if(drunkOrNot== "drunk")
            {
                isDrunk = true;
            }
            Threeuple<string, int,bool> personBeer = new Threeuple<string, int,bool>();
            personBeer.AddItems(personNameBeer, beerCount,isDrunk);
            Console.WriteLine($"{personBeer.Item1[0]} -> " +
                $"{personBeer.Item2[0]} -> " +
                $"{personBeer.Item3[0]}");
            string[] intAndDouble = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string name = intAndDouble[0];
            double doubleNumber = double.Parse(intAndDouble[1]);
            string bankAcount = intAndDouble[2];
            Threeuple<string, double,string> numAndDoubleNum = 
                new Threeuple<string, double,string>();
            numAndDoubleNum.AddItems(name, doubleNumber,bankAcount);
            Console.WriteLine($"{numAndDoubleNum.Item1[0]} -> " +
                $"{numAndDoubleNum.Item2[0]} -> {numAndDoubleNum.Item3[0]}");
        }
    }
}