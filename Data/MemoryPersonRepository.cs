using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Data
{
    public class MemoryPersonRepository : IPersonRepository
    {
        private List<Person> _personList;

        public MemoryPersonRepository()
        {
            _personList = new List<Person>(){
                new Person
                {
                    PersonId = 1,
                    FirstName = "Bob",
                    LastName = "Smith",
                    Role = Role.Admin
                },
                new Person
                {
                    PersonId = 2,
                    FirstName = "Kevin",
                    LastName = "Trachett",
                    Role = Role.Admin
                },
                new Person
                {
                    PersonId = 3,
                    FirstName = "Stuart",
                    LastName = "Smith",
                    Role = Role.Admin
                },
                new Person
                {
                    PersonId = 4,
                    FirstName = "Joe",
                    LastName = "Able",
                    Role = Role.Admin
                }
            };
        }

        public void Add(Person person)
        {
            _personList.Add(person);
        }

        public IEnumerable<Person> GetAll()
        {
            return _personList;
        }

        public Person GetbyId(int id)
        {
            return _personList.FirstOrDefault(p => p.PersonId == id);
        }
    }
}
