using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonLookup.Models;
using PersonLookup.Tools;

namespace PersonLookup.Pages
{
    public class ResultsModel : PageModel
    {
        private readonly IPersonRepository personRepository;

        [BindProperty(SupportsGet = true)]
        public string value { get; set; }
        public IEnumerable<People> People { get; set; }

        public ResultsModel(IPersonRepository personRepo)
        {
            personRepository = personRepo;
        }

         public void OnGet(string value)
        {
            //IEnumerable<People> results = (personRepository.FindPerson(value)).;
            People = personRepository.FindPerson(value);
        }
    }
}
