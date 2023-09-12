namespace _07._Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            string[]personNameAndAdress=Console.ReadLine()
             .Split(" ",StringSplitOptions.RemoveEmptyEntries)
             .ToArray();
            string personName = personNameAndAdress[0];
            string personAddress = personNameAndAdress[1];
            Turple<string, string> personAdrees = new Turple<string, string>();
            personAdrees.AddItems(personName, personAddress);
            Console.WriteLine($"{personAdrees.Item1[0]} -> {personAdrees.Item2[0]}");
            string[] personNameAndBeer = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
            string personNameBeer = personNameAndBeer[0];
            int beerCount = int.Parse(personNameAndBeer[1]);
            Turple<string,int>personBeer=new Turple<string,int>();
            personBeer.AddItems(personNameBeer, beerCount);
            Console.WriteLine($"{personBeer.Item1[0]} -> {personBeer.Item2[0]}");
            string[] intAndDouble = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int number = int.Parse(intAndDouble[0]);
            double doubleNumber = double.Parse(intAndDouble[1]);
            Turple<int, double> numAndDoubleNum = new Turple<int, double>();
            numAndDoubleNum.AddItems(number, doubleNumber);
            Console.WriteLine($"{numAndDoubleNum.Item1[0]} -> {numAndDoubleNum.Item2[0]}");






        }
    }
}