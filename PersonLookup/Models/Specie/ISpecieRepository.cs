using PersonLookup.Tools;

namespace PersonLookup.Models
{
    public interface ISpecieRepository
    {
        Specie GetSpeciesId(string specieId);
    }
}
