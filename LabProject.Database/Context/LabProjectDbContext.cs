using LabProject.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace LabProject.Database.Context
{
    public class LabProjectDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasMany(a => a.Songs)
                .WithOne(s => s.Author)
                .HasForeignKey(s => s.AuthorId);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId);

           
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                    .UseSqlServer("Server=localhost;Database=netbase;Integrated Security = SSPI;TrustServerCertificate=True").LogTo(Console.WriteLine);
        }
    }
}
