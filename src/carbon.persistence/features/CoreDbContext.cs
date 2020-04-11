using carbon.core.domain.model;
using carbon.core.domain.model.account;
using carbon.core.domain.model.registration;
using Microsoft.EntityFrameworkCore;

namespace carbon.persistence.features
{
    public class CoreDbContext : DbContext
    {
        public CoreDbContext(DbContextOptions options) : base(options)
        {
            
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<CoreUser> CoreUsers { get; set; }

        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        
        
        
    }
}