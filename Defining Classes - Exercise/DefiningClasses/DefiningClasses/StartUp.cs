namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
           int count=int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 1; i <= count; i++)
            {
                string[] people=Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                string name = people[0];
                int age = int.Parse(people[1]);
                Person person = new Person(name,age);
                family.AddMember(person);

            }
            List<Person>list=family.GetOldPersons();
            list=list.OrderBy(p=>p.Name).ToList();
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }
        }
    }
}