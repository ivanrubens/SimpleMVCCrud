using Microsoft.EntityFrameworkCore;

namespace SimpleCRUD.Models
{
    public class SimpleCRUDDBContext: DbContext
    {
        public SimpleCRUDDBContext(DbContextOptions<SimpleCRUDDBContext> options) : base(options)
        {

        }

        public DbSet<Books> Books { get; set; }
    }
}
