using Microsoft.AspNetCore.Builder;
using System.ComponentModel;

namespace LitterBox.Api.Models.Enums
{
    public enum PetVolumeSize
    {
        [Description("NONE")]
        NONE = 0,

        [Description("ITSYBITSY")]
        ITSYBITSY = 1,

        [Description("SHORTY")]
        SHORTY = 2,

        [Description("MIDDO")]
        MIDDO = 3,

        [Description("TALLBOI")]
        TALLBOI = 4,

        [Description("GIRAFFENECK")]
        GIRAFFENECK = 5,
    }
}
