using GPostulant.Data;
using GPostulant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System;
using System.Linq;
using System.Collections.Generic;
#nullable disable
namespace MyApp.Namespace
{
    public class IndexModel : PageModel
    {
        private readonly PostulantContext postulantContext;

        public IndexModel(PostulantContext postulantContext)
        {
            this.postulantContext = postulantContext;
        }
        [BindProperty]
        public List<Postulant> postulantsListe {get; set;} = new ();

        [BindProperty(SupportsGet=true)]
        public string SearchString {get; set;}

        public void OnGet()
        {
            

            var searching = from m in postulantContext.postulants select m; 
            if (!string.IsNullOrEmpty(SearchString))
            {
                searching = searching.Where(s => s.Nom.ToLower().Contains(SearchString.ToLower()));
                postulantsListe = searching.ToList();
            } else {

                postulantsListe = this.postulantContext.postulants.ToList();
            }
        }
    }
}
