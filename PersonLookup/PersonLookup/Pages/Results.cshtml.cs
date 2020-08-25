using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonLookup.Models;
using PersonLookup.Tools;

namespace PersonLookup.Pages
{
    public class ResultsModel : PageModel
    {
        private readonly IPersonRespository personRepository;

        [BindProperty(SupportsGet = true)]
        public string value { get; set; }
        public IEnumerable<People> people { get; private set; }

        public ResultsModel(IPersonRespository personRepo)
        {
            this.personRepository = personRepo;
        }

        //function for getting results from azure sql db based on term serached by user. Will return matches if any, and send to the cshtml to display
        public void OnGet(string value)
        {
            people = personRepository.FindPerson(value);
        }
    }
}
