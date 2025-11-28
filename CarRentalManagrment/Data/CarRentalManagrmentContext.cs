using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CarRentalManagrment.Data;
using CarRentalManagrment.Configurations.Entities;

namespace CarRentalManagrment.Data
{
    public class CarRentalManagrmentContext(DbContextOptions<CarRentalManagrmentContext> options) : IdentityDbContext<CarRentalManagrmentUser>(options)
    {
    public DbSet<CarRentalManagrment.Domain.Make> Make { get; set; } = default!;
        public DbSet<CarRentalManagrment.Domain.Model> Model { get; set; } = default!;
        public DbSet<CarRentalManagrment.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<CarRentalManagrment.Domain.Colour> Colour { get; set; } = default!;
        public DbSet<CarRentalManagrment.Domain.Customer> Customer { get; set; } = default!;
        public DbSet<CarRentalManagrment.Domain.Vehicle> Vehicle { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)

        {

            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ColourSeed());
            builder.ApplyConfiguration(new MakeSeed());
            builder.ApplyConfiguration(new ModelSeed());

        }


    }
}
