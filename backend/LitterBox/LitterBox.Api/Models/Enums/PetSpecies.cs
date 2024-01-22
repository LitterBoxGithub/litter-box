using System.ComponentModel;

namespace LitterBox.Api.Models.Enums
{
    public enum PetSpecies
    {
        [Description("NONE")]
        NONE = 0,

        [Description("OTHER")]
        OTHER = 1,

        [Description("DOG")]
        DOG = 2,

        [Description("CAT")]
        CAT = 3,

        [Description("FISH")]
        FISH = 4,

        [Description("REPTILE")]
        REPTILE = 5,

        [Description("AMPHIBIAN")]
        AMPHIBIAN = 6,

        [Description("BIRD")]
        BIRD = 7,

        [Description("RODENT")]
        RODENT = 8,

        [Description("HORSE")]
        HORSE = 9,

    }
}
