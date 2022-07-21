using Arthes.DATA.Enums;

namespace Arthes.DATA.Models
{
    public class ModelRevista : ModelBase<ModelRevista>
    {
        public string? Tema { get; set; }
        public int? NumeroEdicao { get; set; }
        public Mes? MesEdicao { get; set; }
        public int? AnoEdicao { get; set; }
        public byte[]? Photo { get; set; }
    }
}
