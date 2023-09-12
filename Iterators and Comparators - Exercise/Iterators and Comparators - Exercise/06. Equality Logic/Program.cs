namespace _06._Equality_Logic
{
    internal class Program
    {
        static void Main(string[] args)
        {
           HashSet<Person>hashSetPersons=new HashSet<Person>();
           SortedSet<Person>sortHashSetPersons=new SortedSet<Person>();
            int count =int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] personsPros = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person()
                {
                    Name = personsPros[0],
                    Age = int.Parse(personsPros[1])
                };
                hashSetPersons.Add(person);
                sortHashSetPersons.Add(person);
                
            }
            Console.WriteLine($"{hashSetPersons.Count}");
            Console.WriteLine(sortHashSetPersons.Count);
        }
    }
}