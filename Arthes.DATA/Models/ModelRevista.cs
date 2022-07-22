using System.ComponentModel.DataAnnotations;

using Arthes.DATA.Enums;

namespace Arthes.DATA.Models
{
    public class ModelRevista : ModelBase<ModelRevista>
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo obrigatório")]
        public string Tema { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo obrigatório")]
        public int NumeroEdicao { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo obrigatório")]
        public Mes MesEdicao { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo obrigatório")]
        public int AnoEdicao { get; set; }

        public byte[]? Photo { get; set; }
    }
}
