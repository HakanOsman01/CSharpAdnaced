namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] expresion = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Stack<int>numbers=new Stack<int>();
            Stack<string>symbols=new Stack<string>();
            PushInStacksExpression(expresion,numbers,symbols);
            int sum = ProcessSum(numbers, symbols);
            sum += numbers.Peek();
            Console.WriteLine(sum);


        }

        static int ProcessSum( Stack<int> numbers, Stack<string> symbols)
        {
            int sum = 0;
            while(symbols.Count!=0)
            {
                string currentSymbol =symbols.Peek();
                if (currentSymbol == "-")
                {
                    sum -= numbers.Pop();
                }
                else
                {
                    sum+=numbers.Pop();
                }
                symbols.Pop();
            }
            return sum;
            
        }

        static void PushInStacksExpression(string[] expresion, Stack<int> numbers, 
            Stack<string> symbols)
        {
            foreach(string currentElement in expresion)
            {
                if(currentElement=="+" || currentElement=="-")
                {
                    symbols.Push(currentElement);
                }
                else 
                {
                    numbers.Push(int.Parse(currentElement));
                    
                }
            }

        }
    }
}