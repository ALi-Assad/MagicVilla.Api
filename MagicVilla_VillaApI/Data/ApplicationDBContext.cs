using MagicVilla_VillaApI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaApI.Data
{
    public class ApplicationDBContext(DbContextOptions<ApplicationDBContext> options
        ) : DbContext(options)
    {

        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
        new Villa
        {
            Id = 1,
            Name = "Sunset Villa",
            Detials = "A beautiful villa with a stunning sunset view.",
            Rate = 250.0,
            Sqft = 1500,
            Occupancy = 4,
            ImageUrl = "https://example.com/images/sunset_villa.jpg",
            Amenity = "Pool, Wi-Fi, Breakfast",
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now
        },
        new Villa
        {
            Id = 2,
            Name = "Mountain Retreat",
            Detials = "A cozy retreat in the mountains.",
            Rate = 300.0,
            Sqft = 2000,
            Occupancy = 6,
            ImageUrl = "https://example.com/images/mountain_retreat.jpg",
            Amenity = "Fireplace, Hiking Trails, Wi-Fi",
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now
        },
        new Villa
        {
            Id = 3,
            Name = "Beachfront Bungalow",
            Detials = "A charming bungalow right on the beach.",
            Rate = 400.0,
            Sqft = 1800,
            Occupancy = 5,
            ImageUrl = "https://example.com/images/beachfront_bungalow.jpg",
            Amenity = "Beach Access, Wi-Fi, BBQ Grill",
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now
        },
        new Villa
        {
            Id = 4,
            Name = "City Lights Loft",
            Detials = "A modern loft with a view of the city lights.",
            Rate = 350.0,
            Sqft = 1200,
            Occupancy = 3,
            ImageUrl = "https://example.com/images/city_lights_loft.jpg",
            Amenity = "Wi-Fi, Gym, Rooftop Access",
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now
        },
        new Villa
        {
            Id = 5,
            Name = "Countryside Cottage",
            Detials = "A quaint cottage in the countryside.",
            Rate = 200.0,
            Sqft = 1400,
            Occupancy = 4,
            ImageUrl = "https://example.com/images/countryside_cottage.jpg",
            Amenity = "Garden, Wi-Fi, Fireplace",
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now
        },
        new Villa
        {
            Id = 6,
            Name = "Lakeview Lodge",
            Detials = "A luxurious lodge with a view of the lake.",
            Rate = 450.0,
            Sqft = 2200,
            Occupancy = 8,
            ImageUrl = "https://example.com/images/lakeview_lodge.jpg",
            Amenity = "Lake Access, Wi-Fi, Hot Tub",
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now
        }
    );
        }
    }
}
