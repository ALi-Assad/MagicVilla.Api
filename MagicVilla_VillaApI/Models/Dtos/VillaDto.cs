using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace MagicVilla_VillaApI.Models.Dtos
{
    [DataContract]
    public record class VillaDto(
        int Id,
        [property: DataMember][Required][StringLength(30)] String Name,
        [property: DataMember][Required] int Sqft,
        [property: DataMember][Required] int Occupancy,
        [property: DataMember] string? Details = null,
        [property: DataMember] double? Rate = null,
        [property: DataMember] string? ImageUrl = null,
        [property: DataMember] string? Amenity = null
        );
}
