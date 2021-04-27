using Microsoft.EntityFrameworkCore;

namespace api_example
{
    public class DbContextApp : DbContext
    {
        public DbSet<Entidade> Entidades { get; set; }

        public DbContextApp(DbContextOptions<DbContextApp> options)
            : base(options)
        {
        }
    }
}