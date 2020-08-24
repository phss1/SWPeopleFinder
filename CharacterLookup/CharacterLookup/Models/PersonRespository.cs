using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StarWarsApiCSharp;
using CharacterLookup.Models;

namespace CharacterLookup.Models
{
    public class PersonRespository : IPersonRespository
    {
        private List<Person> _personList;

        IRepository<Person> personRepo = new Repository<Person>();

        public PersonRespository()
        {
            _personList = new List<Person>()
            {
                new Person() {  }
            }
        }
        //private ICollection<Person> personMatchList = personRepo.GetEntities();

        
    }
}
