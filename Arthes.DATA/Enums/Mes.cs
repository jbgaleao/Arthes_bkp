using System.ComponentModel;

namespace Arthes.DATA.Enums
{
    public enum Mes : int
    {
        JANEIRO = 1,
        FEVEREIRO,
        [Description("MARÇO")] MARCO,
        ABRIL,
        MAIO,
        JUNHO,
        JULHO,
        AGOSTO,
        SETEMBRO,
        OUTUBRO,
        NOVEMBRO,
        DEZEMBRO
    }
}
