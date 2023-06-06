using System.ComponentModel;

namespace LitterBox.Api.Models.Enums
{
    public enum PetMassSize
    {
        [Description("NONE")]
        NONE = 0,

        [Description("FEATHERWEIGHT")]
        FEATHERWEIGHT = 1,

        [Description("SMOLBEAN")]
        SMOLBEAN = 2,

        [Description("FINEPET")]
        FINEPET = 3,

        [Description("CHOMNK")]
        CHOMNK = 4,

        [Description("OHLAWD")]
        OHLAWD = 5,
    }
}
