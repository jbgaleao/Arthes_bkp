using Arthes.DATA.Enums;

namespace Arthes.DATA.Models
{
    public class RevistaModel : BaseModel<RevistaModel>
    {
        public string? Tema { get; set; }
        public int NumeroEdicao { get; set; }
        public Mes MesEdicao { get; set; }
        public int AnoEdicao { get; set; }

    }
}
