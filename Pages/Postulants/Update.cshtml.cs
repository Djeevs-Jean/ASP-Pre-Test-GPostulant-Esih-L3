using GPostulant.Data;
using GPostulant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
#nullable disable
namespace MyApp.Namespace
{
    public class UpdateModel : PageModel
    {
        private readonly PostulantContext postulantContext;

        public UpdateModel(PostulantContext postulantContext)
        {
            this.postulantContext = postulantContext;
        }

        [BindProperty]

        public Postulant postulantUpdate {get; set;} = new();

        public void OnGet(int? id)
        {
            if (id==null)
            {
                NotFound();
            }
            this.postulantUpdate = this.postulantContext.postulants.FirstOrDefault(m=>m.Id==id);
        }

        public IActionResult OnPost() {
            this.postulantContext.Attach(this.postulantUpdate).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.postulantContext.SaveChanges();
            return RedirectToPage("./Index");
        }
    }
}
