using CRUD_basico.Controllers;
using Microsoft.EntityFrameworkCore;

namespace CRUD_basico.Models
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        
        }

        public DbSet<Produto> Produto { get; set; }
    }
}
