using FileRepositoryRazor.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using File = FileRepositoryRazor.Models.File;

namespace FileRepositoryRazor.Data;

public class FileRepositoryContext : IdentityDbContext
{
    public DbSet<User>? Users { get; set; }

    public DbSet<Folder>? Folders { get; set; }

    public DbSet<File>? Files { get; set; }

    private readonly IConfiguration _configuration;

    public FileRepositoryContext(DbContextOptions<FileRepositoryContext> options, IConfiguration configuration)
        : base(options)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(
            _configuration.GetConnectionString("MyDbContext"),
            new MySqlServerVersion(new Version(8, 0, 11))
        );
    }
    
    public void Add<T>(T entity) where T : class
    {
        Set<T>().Add(entity);
    }

    public void SaveChanges()
    {
        base.SaveChanges();
    }
}