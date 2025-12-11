using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_6
{
    public class PersonListDataSource : IPersonDataSource
    {
        public PersonListDataSource()
        {
            people.Add(new Person { Name = "Alice", Phone = "123-456-7890" });
            people.Add(new Person { Name = "Bob", Phone = "987-654-3210" });
            people.Add(new Person { Name = "Charlie", Phone = "555-555-5555" });
        }

        private List<Person> people = new();
        public void Add(Person person)
        {
            people.Add(person);
        }

        public void Delete(Person person)
        {
            people.Remove(person);
        }

        public IEnumerable<Person> GetPeople()
        {
            return people.ToList();
        }

        public IEnumerable<Person> GetPeople(string filter)
        {
            return people
                .Where(p => p.Name
                .Contains(filter, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public void SaveChanges()
        {
            // This violates the Interface Segregation Principle because this class is 
            // forced to implement this method even though it doesn't need it and has
            // no real way to save changes since it's an in-memory list
        }
    }
}
