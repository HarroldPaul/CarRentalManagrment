using CarRentalManagrment.Configurations.Entities;
using CarRentalManagrment.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagrment.Data
{
    public class CarRentalManagrmentContext : DbContext
    {
        public CarRentalManagrmentContext (DbContextOptions<CarRentalManagrmentContext> options)
            : base(options)
        {
        }

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
