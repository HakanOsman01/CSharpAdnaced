namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            int[]array=Console.ReadLine().Split().Select(int.Parse).ToArray();
            SortArray(array);
            Console.WriteLine(string.Join(' ',array));
        }
        public static void SortArray(int[]array)
        {
            var arrayLength = array.Length;

            for (int i = 0; i < arrayLength - 1; i++)
            {
                var smallestVal = i;

                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (array[j] < array[smallestVal])
                    {
                        smallestVal = j;
                    }
                }

                var tempVar = array[smallestVal];
                array[smallestVal] = array[i];
                array[i] = tempVar;
            }
            
        }
    }
}