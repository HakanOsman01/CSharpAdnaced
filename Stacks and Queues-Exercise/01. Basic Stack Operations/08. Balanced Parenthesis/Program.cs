namespace _08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //{{[[(())]]}}
            string expression=Console.ReadLine();
            Queue<char> queue = new Queue<char>();
            Stack<char> stack = new Stack<char>();
            PutInStackAndQueue(expression, queue, stack);
            bool isBalanced = true;
            while (stack.Count !=0 && queue.Count!=0)
            {
                char currentOpenBracket = queue.Peek();
                char currentCloseBracket = stack.Peek();
                if ((currentOpenBracket == '(' && currentCloseBracket==')')
                    || (currentOpenBracket=='[' && currentCloseBracket==']')||
                   (currentOpenBracket=='{' && currentCloseBracket=='}') 
                   || (currentOpenBracket==')' && currentCloseBracket=='(')
                   || (currentOpenBracket == ']' && currentCloseBracket == '[')
                   || (currentOpenBracket == '}' && currentCloseBracket == '{'))
                {
                    queue.Dequeue();
                    stack.Pop();
                    continue;

                }
                isBalanced = false;
                break;
            }
            if(isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
    

        }
        static void PutInStackAndQueue(string expression, 
            Queue<char> queue, Stack<char> stack)
        {
            foreach (char currentBracket in expression) 
            {
                queue.Enqueue(currentBracket);
            }
            foreach (char currentBracket in expression) 
            {
                stack.Push(currentBracket);
            }

        }
    }
}