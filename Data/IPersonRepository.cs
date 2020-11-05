using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Data
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetAll();
        Person GetbyId(int id);
        void Add(Person person);
    }
}
