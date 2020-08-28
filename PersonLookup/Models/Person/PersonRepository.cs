using System.Collections.Generic;
using System.Linq;
using PersonLookup.Tools;

namespace PersonLookup.Models
{
    public class PersonRepository : IPersonRepository
    {
        private List<People> _personList;
        private SharpTrooperCore core = new SharpTrooperCore();

        public PersonRepository()
        {
            _personList = new List<People>(core.GetAllPeople().results);
        }

        public IEnumerable<People> FindPerson(string searchTerm)
        {
            IEnumerable<People> collection = _personList;
            return (collection.Where(f => f.name.Contains(searchTerm))).ToList();
        }
    }
}
