namespace MagicVilla_VillaApI.Models
{
    public class Villa
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Detials { get; set; } = "";
        public double? Rate { get; set; }
        public required int Sqft { get; set; }
        public required int Occupancy { get; set; }
        public string? ImageUrl { get; set; }
        public string? Amenity { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
