using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {

        private List<Person> persons { get; set; }
        public Family()
        {
            this.persons = new List<Person>();
            
        }
      
        
        public void AddMember(Person member)
        {
            this.persons.Add(member);

        }
        public Person GetOldestMember() 
        {
            return persons.OrderByDescending(p => p.Age).FirstOrDefault();
            
        }
        public List<Person> GetOldPersons() 
        {
            List<Person> list = new List<Person>();
            foreach (Person person  in this.persons)
            {
                if (person.Age > 30)
                {
                    list.Add(person);
                }
            }
            return list;
        }
    }
}
