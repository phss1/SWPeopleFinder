using PersonLookup.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonLookup.Models
{
    public class SpecieRepository : ISpecieRepository
    {
        private Specie _specie;
        private SharpTrooperCore core = new SharpTrooperCore();

        public SpecieRepository(string specieId)
        {
            _specie = core.GetSpecie(specieId);
        }

        public Specie GetSpeciesId(string specieId)
        {
            return _specie;
        }
    }
}
