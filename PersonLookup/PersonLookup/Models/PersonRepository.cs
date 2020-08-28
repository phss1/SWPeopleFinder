using System;
using System.Collections.Generic;
using System.Linq;
using PersonLookup.Tools;

namespace PersonLookup.Models
{
    public class PersonRepository : IPersonRepository
    {
        private List<People> _personList;
        private SharpTrooperCore core = new SharpTrooperCore();

        //IRepository<Person> personRepo = new Repository<Person>();

        public PersonRepository()
        {
            _personList = new List<People>(core.GetAllPeople().results);
        }

        public IEnumerable<People> FindPerson(string searchTerm)
        {
            IEnumerable<People> collection = _personList;

            if (string.IsNullOrEmpty(searchTerm))
            {
                return collection;
            }

            return (collection.Where(f => f.name.Contains(searchTerm))).ToList<People>();
        }


        //private ICollection<Person> personMatchList = personRepo.GetEntities();


    }
}
