using MagicVilla_VillaApI.Models.Dtos;

namespace MagicVilla_VillaApI.Data
{
    public static class VillaStore
    {

        private readonly static List<VillaDto> villaList = new List<VillaDto>
            {
                new(1, "Pool View", 100, 4 ),
                new(2, "Beach View", 300,3 )
            };


        public static List<VillaDto> VillaList { get => villaList; }
    }
}
