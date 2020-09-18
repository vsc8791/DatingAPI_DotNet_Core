using Microsoft.EntityFrameworkCore;
using DatingApp.API.Models;


namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.Migrate();
        }
        public DbSet<Value> Values { get; set; }
        // public DbSet<Book> Books { get; set; }
        // public DbSet<Publisher> Publishers { get; set; }

        //  protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {

        //     base.OnModelCreating(modelBuilder);
        //     modelBuilder.Entity<Publisher>(entity =>
        //           {
        //               entity.HasKey(e => e.ID);
        //               entity.Property(e => e.Name).IsRequired();
        //           });

        //     modelBuilder.Entity<Book>(entity =>
        //           {
        //               entity.HasKey(e => e.ISBN);
        //               entity.Property(e => e.Title).IsRequired();
        //               entity.HasOne(d => d.Publisher)
        //         .WithMany(p => p.Books);
        //           });
        // }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     string conString = "server=localhost : database=employeedb; user=root; password=''";
        //     optionsBuilder.UseMySQL(conString);
        // }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     base.OnModelCreating(modelBuilder);

        //     modelBuilder.Entity<Value>(entity =>
        //         {
        //             entity.HasKey(e => e.Id);
        //             entity.Property(e => e.Name).IsRequired();

        //         });
        // }
    }
}