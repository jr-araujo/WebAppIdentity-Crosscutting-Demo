using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WebAppSoC.Infrastructure.Crosscutting.Security
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>().ToTable("Usuarios", "dbo");
            modelBuilder.Entity<IdentityUser>().ToTable("Usuarios", "dbo");
            modelBuilder.Entity<IdentityRole>().ToTable("Papeis", "dbo");
            modelBuilder.Entity<IdentityUserRole>().ToTable("UsuarioPapeis", "dbo");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("UsuarioPermissoes", "dbo");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("UsuarioLogins", "dbo");
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}