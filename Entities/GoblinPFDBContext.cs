using Microsoft.EntityFrameworkCore;

namespace GoblinPF.Entities
{
    public class GoblinPFDBContext : DbContext
    {
        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<Category> Categories { get; set; }

        public GoblinPFDBContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}