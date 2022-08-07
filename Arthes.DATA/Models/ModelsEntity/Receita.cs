
using Arthes.DATA.Enums;

namespace Arthes.DATA.Models.ModelsEntity
{
    public partial class Receita
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Dificuldade NivelDificuldade { get; set; }
        public decimal Altura { get; set; }
        public int? RevistaId { get; set; }

        public virtual Revista Revista { get; set; }
    }
}