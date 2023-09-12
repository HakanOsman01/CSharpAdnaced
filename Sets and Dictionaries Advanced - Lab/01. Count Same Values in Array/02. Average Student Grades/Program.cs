namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string,List<decimal>> studentsByGrades = new Dictionary<string,List<decimal>>();
            for (int i = 0; i < n; i++)
            {
                string[] currentStudent = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string studentName = currentStudent[0]; 
                decimal studentGrade = decimal.Parse(currentStudent[1]);
                if (!studentsByGrades.ContainsKey(studentName))
                {
                    studentsByGrades[studentName] = new List<decimal>();
                }
                studentsByGrades[studentName].Add(studentGrade);
            }
            foreach(var item in studentsByGrades)
            {
                Console.Write($"{item.Key} -> ");
                for (int j = 0; j < item.Value.Count; j++)
                {
                    Console.Write($"{item.Value[j]:f2} ");
                }
                decimal avaregeGrade = item.Value.Average();
                Console.Write($"(avg: {avaregeGrade:f2})");
                Console.WriteLine();
            }
        }
    }
}