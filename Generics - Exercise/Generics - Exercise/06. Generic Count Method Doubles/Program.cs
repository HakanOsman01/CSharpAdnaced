namespace _06._Generic_Count_Method_Doubles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<double> objects = new Box<double>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double currentValue = double.Parse(Console.ReadLine());
                objects.List.Add(currentValue);
            }
            double element = double.Parse(Console.ReadLine());
            int countBiggesValues = objects.CompareTo(element);
            Console.WriteLine(countBiggesValues);
        }
    }
}