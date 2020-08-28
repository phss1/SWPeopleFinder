using PersonLookup.Tools;
using System.Collections.Generic;

namespace PersonLookup.Models.Specie
{
    public interface ISpecieRepository
    {
        IEnumerable<Tools.Specie> GetSpeciesId(string specieId);
    }
}
