namespace _01._Lootbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstLootBox = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> secondLootBox = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int claimedItems = 0;
            while(firstLootBox.Any() && secondLootBox.Any())
            {
                int firstBox=firstLootBox.Peek();
                int secondBox=secondLootBox.Peek();
                int sum = firstBox + secondBox;
                if (sum % 2 == 0)
                {
                    claimedItems += sum;
                    firstLootBox.Dequeue();
                    secondLootBox.Pop();
                    continue;
                }
                ProcessBoxes(firstLootBox, secondLootBox);

            }
            if (!firstLootBox.Any())
            {
                Console.WriteLine("First lootbox is empty");
            }
            else
            {
                Console.WriteLine("Second lootbox is empty");
            }
            if (claimedItems >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {claimedItems}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {claimedItems}");
            }
        }
        static void ProcessBoxes(Queue<int> firstLootBox, Stack<int> secondLootBox)
        {
            int lastItem = secondLootBox.Pop();
            firstLootBox.Enqueue(lastItem);
        }
    }

}