namespace _03.Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n=int.Parse(Console.ReadLine());
           SortedSet<string>elements = new SortedSet<string>();
           for (int i = 0; i < n; i++)
           {
                string[]chemistryElements=Console.ReadLine()
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int j = 0; j < chemistryElements.Length; j++)
                {
                    elements.Add(chemistryElements[j]);
                }
                  

           }
           foreach (string element in elements)
            {
                Console.Write($"{element} ");
            }
        }
    }
}