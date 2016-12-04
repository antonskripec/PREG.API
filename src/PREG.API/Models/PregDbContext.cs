using Microsoft.EntityFrameworkCore;

namespace PREG.API.Models
{
    public class PregDbContext : DbContext
    {
        public PregDbContext(DbContextOptions<PregDbContext> options) : base(options)
        {
            
        }

        public DbSet<ApprovalProcedure> ApprovalProcedures { get; set; }

        public DbSet<Distributor> Distributors { get; set; }

        public DbSet<DosageForm> DosageForms { get; set; }

        public DbSet<ErrandTypeGroup> ErrandTypeGroups { get; set; }

        public DbSet<ErrandType> ErrandTypes { get; set; }

        public DbSet<Manufacturer> Manufacturers { get; set; }

        public DbSet<PhaseGroup> PhaseGroups { get; set; }

        public DbSet<Phase> Phases { get; set; }

        public DbSet<Permission> Permissions { get; set; }

    }
}