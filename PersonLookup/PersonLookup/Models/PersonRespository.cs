using System;
using System.Collections.Generic;
using System.Linq;
using PersonLookup.Tools;

namespace PersonLookup.Models
{
    public class PersonRespository : IPersonRespository
    {
        private SharpEntityResults<People> _personList;
        private SharpTrooperCore core = new SharpTrooperCore();

        //IRepository<Person> personRepo = new Repository<Person>();

        public PersonRespository()
        {
            _personList = core.GetAllPeople();
        }

        public IEnumerable<People> FindPerson(string searchTerm)
        {
            IEnumerable<People> collection = (IEnumerable<People>)_personList;

            if (string.IsNullOrEmpty(searchTerm))
            {
                return collection;
            }

            return collection.Where(f => f.name.Contains(searchTerm));
        }


        //private ICollection<Person> personMatchList = personRepo.GetEntities();


    }
}
