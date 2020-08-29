using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonLookup.Models;
using PersonLookup.Tools;

namespace PersonLookup.Pages
{
    public class ResultsModel : PageModel
    {
        private readonly IPersonRepository personRepository;
        private readonly ISpecieRepository specieRepository;

        [BindProperty(SupportsGet = true)]
        public string value { get; set; }
        public IEnumerable<People> People { get; set; }
        private IEnumerable<People> newPeopleLst;

        public IEnumerable<Specie> Specie { get; set; }

        public ResultsModel(IPersonRepository personRepo, ISpecieRepository specieRepo)
        {
            personRepository = personRepo;
            specieRepository = specieRepo;
        }

        public void OnGet(string value)
        {
            newPeopleLst = personRepository.FindPerson(value);
            IEnumerable<People> people = personRepository.FindPerson(value);
            People = GetPersonSpecies(people);
        }

        private IEnumerable<People> GetPersonSpecies(IEnumerable<People> list)
        {
            foreach(People person in list)
            {
                if(person.species.Count > 0)
                {
                    string speciesUrl = person.species.First().ToString();
                    string[] speciesUrlSplit = speciesUrl.Split("/");
                    int specieId = speciesUrlSplit.Count() - 2;
                    string speciesId = speciesUrlSplit[specieId];
                    Specie specie = specieRepository.FindSpecie(speciesId).First();
                    person.species.Add(specie.name);
                }
                else
                {
                    person.species.Add("NA");
                }
                
            }

            return list;
        }
    }
}