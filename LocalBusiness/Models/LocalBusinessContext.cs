using Microsoft.EntityFrameworkCore;

namespace LocalBusiness.Models
{
    public class LocalBusinessContext : DbContext
    {
        public LocalBusinessContext(DbContextOptions<LocalBusinessContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Business>()
              .HasData(
                  new Business { BusinessId = 1, Type = "Restaurant", Name = "El Gacho", Location = "Belltown", Description = "Classic American", Review = "Excellent" , Rating = 9},
                  new Business { BusinessId = 1, Type = "Restaurant", Name = "Japonessa", Location = "Downtown", Description = "Modern Japanese", Review = "Great" , Rating = 7},
                  new Business { BusinessId = 1, Type = "Restaurant", Name = "Red Star Tacos", Location = "Fremont", Description = "Mexican", Review = "Mediocre" , Rating = 5},
                  new Business { BusinessId = 1, Type = "Local Produce", Name = "Juan Garden", Location = "White center", Description = "Fresh produces", Review = "Excellent" , Rating = 8},
                  new Business { BusinessId = 1, Type = "Local Shop", Name = "The Plant Store", Location = "White Center", Description = "Plant Shop ", Review = "Excellent" , Rating = 8}
              );
        }

        public DbSet<Business> Businesses { get; set; }
    }
}
