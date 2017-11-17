namespace Uppgift7a.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Uppgift7a.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Uppgift7a.DataAccess.PersonContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Uppgift7a.DataAccess.PersonContext context)
        {
            context.Persons.AddOrUpdate(
                I => I.Name,
                new Person { Name = "Olof", City = "Uppsala", Occupation = "Dataminer" },
                new Person { Name = "Kristian", City = "Oslo", Occupation = "Esport Pro" },
                new Person { Name = "Emma", City = "Göteborg", Occupation = "Game Developer" }
            );
        }
    }
}
