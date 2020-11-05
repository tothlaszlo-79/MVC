using Microsoft.EntityFrameworkCore;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Data
{
    public class PersonRepository : IPersonRepository
    {
        private readonly PersonDbContext _personDbContext;
        public PersonRepository(PersonDbContext personDbContext)
        {
            _personDbContext = personDbContext;
        }

        public void Add(Person person)
        {
            _personDbContext.Add(person);
        }

        public IEnumerable<Person> GetAll()
        {
            return _personDbContext.People.Include(p => p.HomeAddress);
        }

        public Person GetbyId(int id)
        {
            return _personDbContext.People.FirstOrDefault(p => p.PersonId == id);
        }
    }
}
