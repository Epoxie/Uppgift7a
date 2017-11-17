using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Uppgift7a.Models;

namespace Uppgift7a.DataAccess
{
    public class PersonContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public PersonContext() : base("DefaultConnection")
        {

        }
    }
}