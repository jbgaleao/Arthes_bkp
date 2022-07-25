using System.ComponentModel.DataAnnotations;

using Arthes.DATA.Enums;

namespace Arthes.DATA.Models
{
    public class ModelReceita : ModelBase<ModelReceita>
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo obrigatório")]
        public Dificuldade Dificuldade { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo obrigatório")]
        public decimal Altura { get; set; }


        public int RevistaId { get; set; }
        public ModelRevista _ModelRevista { get; set; }



    }
}
