using GPostulant.Data;
using GPostulant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
#nullable disable
namespace MyApp.Namespace
{
    public class DeleteModel : PageModel
    {
        private readonly PostulantContext postulantContext;

        public DeleteModel(PostulantContext postulantContext)
        {
            this.postulantContext = postulantContext;
        }

        [BindProperty]

        public Postulant postulantDelete {get; set;} = new ();
        public void OnGet(int? id)
        {
            if (id ==null)
            {
                NotFound();
            }
            postulantDelete = this.postulantContext.postulants.FirstOrDefault(m=>m.Id==id);
        }

        public IActionResult OnPost() {
            this.postulantContext.Remove(postulantDelete);
            this.postulantContext.SaveChanges();
            return RedirectToPage("./Index");
        }
    }
}
