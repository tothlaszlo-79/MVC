using Microsoft.EntityFrameworkCore;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MVC.Data
{
    public class PersonDbContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Address> Addresses { get; set; }


        public PersonDbContext(DbContextOptions<PersonDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
                  new Person
                  {
                      PersonId = 1,
                      FirstName = "Bob",
                      LastName = "Smith Db",
                      Role = Role.Admin
                  },
                new Person
                {
                    PersonId = 2,
                    FirstName = "Kevin",
                    LastName = "Trachett Db",
                    Role = Role.Admin
                },
                new Person
                {
                    PersonId = 3,
                    FirstName = "Stuart",
                    LastName = "Smith Db",
                    Role = Role.Admin
                },
                new Person
                {
                    PersonId = 4,
                    FirstName = "Joe",
                    LastName = "Able Db",
                    Role = Role.Admin
                }
                );

        }
    }
}
