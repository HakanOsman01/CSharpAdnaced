namespace Draw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            char firstSymbol = '*';
            char secondSymbol = '#';

            Draw(n,firstSymbol,0);
            //Console.WriteLine();
            //Draw(n,secondSymbol);
            
        }

        static void Draw(int n,char output, int currentIndex)
        {
           
            if (n <= 0)
            {
                currentIndex = n - 1;
                return;
            }
            Console.Write($"{output}");
            Draw(n - 1,output,currentIndex);
            n=currentIndex;
            

        }
    }
}