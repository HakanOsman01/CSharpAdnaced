namespace CustomStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]arrau = Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .Skip(1)
                .Select(int.Parse)
                .ToArray();
            CustomStack stack = new CustomStack();
            stack.Push(list);
            string command=Console.ReadLine();
            while(command!= "END")
            {
                string[] cmdTokens = command.Split(", ");
                switch (cmdTokens[0])
                {
                    case "Push":
                        stack.Push(cmdTokens.Skip(1).ToList());
                       
                }
            }

        }
    }
}