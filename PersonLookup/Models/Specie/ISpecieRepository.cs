using PersonLookup.Tools;
using System.Collections.Generic;

namespace PersonLookup.Models
{
    public interface ISpecieRepository
    {
        IEnumerable<Specie> FindSpecie(string searchValue);
    }
}
