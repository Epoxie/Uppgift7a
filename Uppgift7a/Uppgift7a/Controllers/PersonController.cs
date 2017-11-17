using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Uppgift7a.Models;
using Uppgift7a.Repositories;

namespace Uppgift7a.Controllers
{
    public class PersonController : ApiController
    {
        PersonRepository PersonRepository = new PersonRepository();

        // GET api/person
        public IEnumerable<Person> Get()
        {
            return PersonRepository.GetAllPersons();
        }

        // GET api/person/5
        public Person Get(int id)
        {
            return PersonRepository.GetPersonById(id);
        }

        // POST api/person
        public void Post(Person p)
        {
            PersonRepository.Add(p);
        }

        // PUT api/person/5
        [HttpPost]
        public void Edit(Person p)
        {
            PersonRepository.EditPerson(p);
        }

        // DELETE api/person/5
        [HttpGet]
        public void Delete(int p)
        {
            PersonRepository.Remove(p);
        }
    }
}
