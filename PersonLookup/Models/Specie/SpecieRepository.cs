using PersonLookup.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonLookup.Models
{
    public class SpecieRepository : ISpecieRepository
    {
        private List<Specie> _specieList;
        private SharpTrooperCore core2 = new SharpTrooperCore();

        public SpecieRepository()
        {
            _specieList = new List<Specie>(core2.GetAllSpecies("").results);
        }

        public IEnumerable<Specie> FindSpecie(string searchTerm)
        {
            IEnumerable<Specie> collection = _specieList;
            return collection.Where(f => f.name.Contains(searchTerm)).ToList();
        }
    }
}
