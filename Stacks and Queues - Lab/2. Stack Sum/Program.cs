namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
             .Split(' ', StringSplitOptions.RemoveEmptyEntries)
             .Select(num => int.Parse(num))
             .ToArray();
            Stack<int> stack = new Stack<int>();
            foreach (int num in numbers)
            {
                stack.Push(num);
            }
            string command = Console.ReadLine().ToLower();
            while(command != "end")
            {
                string[]tokens=command.Split().ToArray();
                string action = tokens[0];
                switch (action)
                {
                    case "add":
                        int firstNumber = int.Parse(tokens[1]);
                        int secondNumber = int.Parse(tokens[2]);
                        stack.Push(firstNumber);
                        stack.Push(secondNumber);
                        break;
                    case "remove":
                        int n = int.Parse(tokens[1]);
                        if (n > stack.Count)
                        {
                            command = Console.ReadLine().ToLower();
                            continue;
                        }
                        for (int i = 1; i <= n; i++)
                        {
                            stack.Pop();

                        }
                        break;
                }
                command = Console.ReadLine().ToLower();

            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}