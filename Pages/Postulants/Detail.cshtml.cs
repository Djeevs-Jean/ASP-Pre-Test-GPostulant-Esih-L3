using GPostulant.Data;
using GPostulant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
#nullable disable
namespace MyApp.Namespace
{
    public class DetailModel : PageModel
    {
        private readonly PostulantContext postulantContext;

        public DetailModel(PostulantContext postulantContext)
        {
            this.postulantContext = postulantContext;
        }

        [BindProperty]

        public Postulant postulantDetail {get; set; } = new();

        public void OnGet(int? id)
        {
            if (id == null)
            {
                NotFound();
            }
            this.postulantDetail = this.postulantContext.postulants.FirstOrDefault(m=>m.Id==id);
        }
    }
}
