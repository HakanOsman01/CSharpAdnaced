using System.Formats.Asn1;

namespace _05._Merge_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //Console.WriteLine($"Array: {string.Join(',',array)}");
            MergeSorted.MergeSort(array);
            Console.WriteLine($"{string.Join(' ',array)}");


        }
        
    }
}