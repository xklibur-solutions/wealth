using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace XkliburSolutions.Wealth.Data;
/// <summary>
/// This class represents the database context for the application.
/// It inherits from the IdentityDbContext class and handles CRUD operations related to ASP.NET Identity.
/// <param name="options">Context configuration options.</param>
/// </summary>
public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{
    /// <summary>
    /// Overrides the base <c>OnModelCreating</c> method to configure the model for the database context.
    /// Use this method to define entity mappings, relationships, and other model configurations.
    /// </summary>
    /// <param name="builder">The <c>ModelBuilder</c> instance used for configuring the model.</param>
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<IdentityRole>().ToTable("Roles");
        builder.Entity<ApplicationUser>().ToTable("Users");
        builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");
        builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
        builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");
        builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
        builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");
    }
}
