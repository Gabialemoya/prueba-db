using Microsoft.EntityFrameworkCore;

namespace PruebaDB.Models
{
    public class NotasContext : DbContext
    {
        public NotasContext(DbContextOptions<NotasContext> options) : base(options)
        {

        } 
        public DbSet<Nota> Notas {get; set;}
        public DbSet<Usuario> Usuarios {get; set;}
    }
}