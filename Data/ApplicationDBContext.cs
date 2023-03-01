
using Lucy_BRMS.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    protected readonly IConfiguration Configuration;

   public ApplicationDbContext(IConfiguration configuration)
   {
        Configuration = configuration;
    
   }

    // protected override void OnConfiguring(DbContextOptionsBuilder options)
    // {
    //     // connect to sql server with connection string from app settings
    //     // options.UseSqlServer(Configuration.GetConnectionString("viddlyconnectionstring"));
    //      options.UseNpgsql(Configuration.GetConnectionString("Buildingconnectionstring"));
    // }

    protected override  void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql(Configuration.GetConnectionString("Buildingconnectionstring"));
    }

        

        public DbSet<Building> Buildings { get; set; }
}
