using Problem02.Stack;

namespace Stakc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomStack<int>stack= new CustomStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            foreach (var item in stack)
            {
                Console.Write($"{item} ");
            }
        }
    }
}