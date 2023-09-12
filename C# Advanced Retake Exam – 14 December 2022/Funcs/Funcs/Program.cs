namespace Funcs
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int[]array=Console.ReadLine()
               .Split(" ",StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();
            ReverseTheArray(array, array.Length-1);

        }
        static int ReverseTheArray(int[]array,int index)
        {
            if (index==0)
            {
                Console.Write($"{array[index]}");
                return array[index];
            }
            Console.Write($"{array[index]} ");
            return ReverseTheArray(array, index-1);

               

        }


         
    }
}