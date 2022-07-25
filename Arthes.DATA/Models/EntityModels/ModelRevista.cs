using System.ComponentModel.DataAnnotations;

using Arthes.DATA.Enums;

namespace Arthes.DATA.Models
{
    public class ModelRevista : ModelBase<ModelRevista>
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo obrigatório")]
        public string Tema { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo obrigatório")]
        [Range(1, 9999, ErrorMessage = "Número deve ser positivo")]
        public int NumeroEdicao { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo obrigatório")]
        public Mes MesEdicao { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo obrigatório")]
        [Range(2000, 2030, ErrorMessage = "Ano deve estar entre 200 e 2030")]
        public int AnoEdicao { get; set; }


        public ICollection<ModelReceita>? ListaReceita { get; set; }

    }
}
