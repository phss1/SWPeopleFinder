using System.Collections.Generic;
using PersonLookup.Tools;

namespace PersonLookup.Models
{
    public interface IPersonRepository
    {
        IEnumerable<People> FindPerson(string searchValue);
    }
}
