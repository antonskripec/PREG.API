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
        
        public DbSet<Errand> Errands { get; set; }

        public DbSet<ErrandTypeGroup> ErrandTypeGroups { get; set; }

        public DbSet<ErrandType> ErrandTypes { get; set; }

        public DbSet<PackageDetailType> PackageDetailTypes { get; set; }

        public DbSet<PackageType> PackageTypes { get; set; }

        public DbSet<Manufacturer> Manufacturers { get; set; }

        public DbSet<PhaseGroup> PhaseGroups { get; set; }

        public DbSet<Phase> Phases { get; set; }

        public DbSet<Permission> Permissions { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<UserGroup> UserGroups { get; set; }        

        public DbSet<OpenStorage> OpenStorages { get; set; }

        public DbSet<ResponsibleManager> ResponsibleManagers { get; set; }
        
    }
}