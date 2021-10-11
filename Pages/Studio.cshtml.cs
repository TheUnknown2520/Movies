using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Movies.Model;

namespace Movies.Pages
{
    public class StudioModel : PageModel
    {
        public IEnumerable<Studio> Studios { get; set; }

        public StudioModel()
        {
            Studios = Repository.GetStudios();
        }

        public void OnGet()
        {
            
        }
    }
}
