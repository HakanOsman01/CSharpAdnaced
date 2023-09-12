namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countCommands=int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < countCommands; i++)
            {
                int[]cmdArgs=Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                int action = cmdArgs[0];
                switch (action)
                {
                    case 1:
                        int pushElement = cmdArgs[1];
                        stack.Push(pushElement);
                        break;
                    case 2:
                        if(stack.Count == 0)
                        {
                            continue;
                        }
                        stack.Pop();
                        break;
                    case 3:
                        if (!stack.Any())
                        {
                            continue;

                        }
                        int maxElement = FindMaxElementInStack(stack);
                        Console.WriteLine(maxElement);
                        break;
                    case 4:
                        if (!stack.Any())
                        {
                            continue;

                        }
                        int minElement = FindMinElementInStack(stack);
                        Console.WriteLine(minElement);
                        break;



                }
            }
            string output=string.Join(", ",stack.ToArray());
            Console.WriteLine(output);
        }

        static int FindMinElementInStack(Stack<int> stack)
        {
            int minElement = int.MaxValue;
            int[] array = stack.ToArray();
            foreach (int currentNum in array)
            {
                if (currentNum <= minElement)
                {
                    minElement = currentNum;
                }
            }
            return minElement;
        }

        static int FindMaxElementInStack(Stack<int> stack)
        {
            int maxElement = int.MinValue;
            int[]array=stack.ToArray();
            foreach(int currentNum in array)
            {
                if (currentNum >= maxElement)
                {
                    maxElement = currentNum;
                }
            }
            return maxElement;
        }
    }
}