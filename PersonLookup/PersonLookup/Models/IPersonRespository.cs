using System.Collections.Generic;
using PersonLookup.Tools;

namespace PersonLookup.Models
{
    public interface IPersonRespository
    {
        IEnumerable<People> FindPerson(string searchValue);
    }
}
