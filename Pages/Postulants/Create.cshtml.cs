using GPostulant.Data;
using GPostulant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
#nullable disable
namespace MyApp.Namespace
{
    public class CreateModel : PageModel
    {
        private readonly PostulantContext postulantContext;

        public CreateModel(PostulantContext postulantContext)
        {
            this.postulantContext = postulantContext;
        }

        [BindProperty]
        public Postulant postulantCreate {get; set;} = new Postulant();

        public void OnGet()
        {
        }

        public IActionResult OnPost() {
            this.postulantContext.Add(postulantCreate);
            this.postulantContext.SaveChanges();
            return RedirectToPage("./Index");
        }
    }
}
