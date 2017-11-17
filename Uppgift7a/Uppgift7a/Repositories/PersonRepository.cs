using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Uppgift7a.DataAccess;
using Uppgift7a.Models;

namespace Uppgift7a.Repositories
{
    public class PersonRepository
    {
        PersonContext PersonContext = new PersonContext();

        public IEnumerable<Person> GetAllPersons() {
            return PersonContext.Persons;
        }

        public Person GetPersonById(int id) {
            return PersonContext.Persons.FirstOrDefault(i => i.Id == id);
        }

        public void Add(Person p) {
            PersonContext.Persons.Add(p);
            PersonContext.SaveChanges();
        }

        public void Remove(int id) {
            PersonContext.Persons.Remove(GetPersonById(id));
            PersonContext.SaveChanges();
        }

        public void EditPerson(Person p) {
            PersonContext.Entry(p).State = EntityState.Modified;
            PersonContext.SaveChanges();
        }
    }
}