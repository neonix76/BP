using BP.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace BP.Data;

public class ApplicationContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<ApplicationUser>(i =>
        {
            i.ToTable("AspNetUsers");
            i.HasKey(x => x.Id);
        });

        builder.Entity<IdentityRole>(i =>
        {
            i.ToTable("AspNetRoles");
            i.HasKey(x => x.Id);
        });


        builder.Entity<Post>().Property(z => z.Text).HasMaxLength(150);

        builder.Entity<Post>().HasData(
            new Post
            {
                Id = 1,
                Title = "Test",
                Text = "Test text",
                CreatedDate = DateTime.Now,
            }
            );


        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
    public DbSet<Post> Posts { get; set; }

}
