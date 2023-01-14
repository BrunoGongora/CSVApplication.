using Microsoft.EntityFrameworkCore;

namespace CSVApplication.Models
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options): base(options)
        {

        }
        
        public DbSet<DataUser> DataUsers { get; set; } //Esta es la entidad que se va a agregar a la base de datos
    }
}
