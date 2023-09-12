namespace _4._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5
            string expression=Console.ReadLine();
            Stack<int> brackets = new Stack<int>();
            for (int i = 0; i < expression.Length; i++)
            {
                char currentCharackter = expression[i];
                if (currentCharackter == '(')
                {
                    brackets.Push(i);

                }
                if (currentCharackter == ')')
                {
                    int startIndex = brackets.Peek();
                    int endIndex = i - startIndex + 1;
                    string matching = expression.Substring(startIndex, endIndex);
                    Console.WriteLine(matching);
                    brackets.Pop();
                }

            }
        }
    }
}