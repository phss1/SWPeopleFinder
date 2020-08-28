using PersonLookup.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonLookup.Models.Specie
{
    public class SpecieRepository
    {
        //private Tools.Specie _specie;
        private IEnumerable<Tools.Specie> _specie;
        private SharpTrooperCore core = new SharpTrooperCore();

        public SpecieRepository(string specieId)
        {
            List<Tools.Specie> specie = new List<Tools.Specie>();
            specie.Add(core.GetSpecie(specieId));
            _specie = specie;
        }

        public IEnumerable<Tools.Specie> GetSpeciesId(string searchTerm)
        {
            return _specie.Where(f => f.name.Contains(searchTerm));
        }
    }
}
