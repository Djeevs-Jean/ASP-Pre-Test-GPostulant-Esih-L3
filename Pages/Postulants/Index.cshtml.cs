using GPostulant.Data;
using GPostulant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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
        public List<Postulant> postulantsListe {get; set;} = new();

        public void OnGet()
        {
            postulantsListe = this.postulantContext.postulants.ToList();
        }
    }
}
