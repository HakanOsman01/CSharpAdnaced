using System;
namespace _1._Energy_Drinks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int>caffeine=new Stack<int>(Console.ReadLine()
               .Split(", ",StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse));
            Queue<int> energyDrink=new Queue<int>(Console.ReadLine()
               .Split(", ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse));
            int perNightCoffe = 300;
            int coffe = 0;
            Func<int, int, int> calculateEnergeyDrinks = (int x, int y) => x * y;
            int totalCaffeine = 0;
            int currentCoffeMiligrams = 300;
            while (caffeine.Any() && energyDrink.Any())
            {
                int currentCoffe=caffeine.Peek();
                int currentEnergy=energyDrink.Peek();
                int multiplay=calculateEnergeyDrinks(currentCoffe, currentEnergy);
                if (multiplay <= perNightCoffe)
                {
                    caffeine.Pop();
                    energyDrink.Dequeue();
                   
                    //perNightCoffe += 300-multiplay;
                    multiplay=
                    totalCaffeine +=300-(perNightCoffe - multiplay);



                }
                else
                {
                    caffeine.Pop();
                    energyDrink.Dequeue();
                    energyDrink.Enqueue(currentEnergy);
                    if (totalCaffeine- 30 < 0)
                    {
                        totalCaffeine = 0;
                    }
                    else
                    {
                        totalCaffeine -= 30;
                    }
                   //currentCaffeine = 300-totalCaffeine;


                }
                

            }
            if (energyDrink.Count == 0)
            {
                Console.WriteLine($"At least Stamat wasn't exceeding the maximum caffeine.");
                //Console.WriteLine(string.Join(' ',));
            }
            else
            {
                Console.WriteLine($"Drinks left: {string.Join(", ",energyDrink)}");

            }
            Console.WriteLine($"Stamat is going to sleep with {totalCaffeine} mg caffeine.");

        }
      

    }
}