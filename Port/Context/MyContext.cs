using Microsoft.EntityFrameworkCore;
using Port.Model;

namespace Port.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        public DbSet<Medicine> Medicines { get; set; }
        
    }
}
