using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonLookup.Models;
using PersonLookup.Models.Specie;
using PersonLookup.Tools;

namespace PersonLookup.Pages
{
    public class ResultsModel : PageModel
    {
        private readonly IPersonRepository personRepository;

        [BindProperty(SupportsGet = true)]
        public string value { get; set; }
        public IEnumerable<People> People { get; set; }
        private IEnumerable<People> newPeopleLst;
        private IEnumerable<Specie> _specie;

        public ResultsModel(IPersonRepository personRepo)
        {
            personRepository = personRepo;
        }

        public ResultsModel(ISpecieRepository specieRepo)
        {
            //_specie = specieRepo;
        }

        public void OnGet(string value)
        {
            newPeopleLst = personRepository.FindPerson(value);

            //People = GetPersonSpecies((List<People>)newPeopleLst);
        }

        //private List<People> GetPersonSpecies(List<People> list)
        //{
        //    List<People> newPeopleList;

        //    foreach(People person in list)
        //    {
        //        string speciesUrl = person.species.ToString();

        //    }

        //    return newPeopleList;
        //}
    }
}
