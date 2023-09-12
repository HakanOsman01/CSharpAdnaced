namespace RecursionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Dimitrichko e top!");
            //}
          
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(NFactorial(n));
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(MultiplayArray(array,0));

        }

        private static int MultiplayArray(int[] array, int index)
        {
           if(array.Length == index)
           {
                return 1;
           }
           int currentResult = array[index]*MultiplayArray(array,index+1);
           return currentResult;

        }

        private static int NFactorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            int currentResult = n * NFactorial(n - 1);
            return currentResult;
        }
    }
}