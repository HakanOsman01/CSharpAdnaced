namespace Fibonacii
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int fib=int.Parse(Console.ReadLine());
          // Console.WriteLine(Fibonacii(fib));
           int firstNumber = 1;
           int secondNumber = 1;
           int fibonachii = 1; 
           for (int i = 1; i <= fib; i++)
           {
                if (i < 2)
                {
                    Console.Write($"{firstNumber},{secondNumber}");
                    continue;
                }
                int sum = firstNumber + secondNumber;
                secondNumber = firstNumber;
                firstNumber = sum;
                Console.Write($",{sum}");


                
                
              



            }
        }

        private static int Fibonacii(int fib)
        {
            if (fib == 0)
            {
                return 0;
            }
            if(fib == 1 || fib==2)
            {
                return 1;
            }
            int first = Fibonacii(fib - 1);
            int second=Fibonacii(fib - 2);
           // Console.Write($"{first+second},");
            return first+ second;
        }
    }
}