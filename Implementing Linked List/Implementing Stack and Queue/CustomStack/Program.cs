namespace CustomStack
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomStack stack = new CustomStack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.ForEach(x => Console.Write($"{x} "));
            int firstElement=stack.Peek();
            stack.Pop();
            int secondElement=stack.Peek();
            Console.WriteLine($"{firstElement} {secondElement}");

        }
    }
}