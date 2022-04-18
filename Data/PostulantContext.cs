using GPostulant.Models;
using Microsoft.EntityFrameworkCore;
#nullable disable
namespace GPostulant.Data
{
    public class PostulantContext : DbContext
    {
        
        public PostulantContext(DbContextOptions<PostulantContext> options) : base(options)
        {
        }

        public DbSet<Postulant> postulants {get; set;}
    }
}