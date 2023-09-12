using System;

namespace _05._Comparing_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person>persons=new List<Person>();
            string command = Console.ReadLine();
            while(command!= "END")
            {
                string[]arrayPersons=command
               .Split(" ",StringSplitOptions.RemoveEmptyEntries)
               .ToArray();
                Person person = new Person()
                {
                    Name = arrayPersons[0],
                    Age = int.Parse(arrayPersons[1]),
                    Town = arrayPersons[2]
                };
                persons.Add(person);
                command = Console.ReadLine();
            }
            int compareIndex = int.Parse(Console.ReadLine())-1;
            Person personToComapre = persons[compareIndex];
            int equalCount = 0;
            int diffCount = 0;
            foreach (Person person in persons)
            {
                if (person.CompareTo(personToComapre) == 0)
                {
                    equalCount++;
                }
                else
                {
                    diffCount++;
                }
            }
            if (equalCount == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equalCount} {diffCount} {persons.Count}");
            }



        }
    }
}