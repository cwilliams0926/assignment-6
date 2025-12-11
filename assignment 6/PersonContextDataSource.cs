using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace assignment_6
{
    public class PersonContextDataSource : IPersonDataSource
    {
        private PersonDbContext db;
        public PersonContextDataSource()
        {
            db = new PersonDbContext();
            db.Database.EnsureCreated();
            db.People.Load();
        }

        public IEnumerable<Person> GetPeople()
        {
            return db.People.Local.ToList();
        }

        public IEnumerable<Person> GetPeople(string filter)
        {
            return db.People.Local
                .Where(p => p.Name
                .Contains(filter, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
        public void Add(Person person)
        {
            db.People.Add(person);
        }

        public void Delete(Person person)
        {
            db.People.Remove(person);
        }

        public void SaveChanges()
        {
            db.SaveChanges();
        }
    }
}
