using Microsoft.EntityFrameworkCore;

namespace uniProject.Models;

public class FormContext : DbContext
{
    
    public DbSet<UserModel> Users { get; set; }
    public DbSet<MainFormModel> Forms { get; set; }

    public string DbPath { get; }

    
    public FormContext(DbContextOptions<FormContext> options) : base(options)
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "blogging.db");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MainFormModel>()
            .HasIndex(b => b.NationalId).IsUnique();

        modelBuilder.Entity<MainFormModel>()
            .HasIndex(b => b.PhoneNumber).IsUnique();

        modelBuilder.Entity<MainFormModel>()
            .HasIndex(b => b.PassPortCode).IsUnique();
        
        modelBuilder.Entity<MainFormModel>()
            .HasIndex(b => b.Email).IsUnique();
        
        modelBuilder.Entity<UserModel>()
            .HasIndex(b => b.NationalId).IsUnique();

    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
    
}