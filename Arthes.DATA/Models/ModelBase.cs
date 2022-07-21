using System.ComponentModel.DataAnnotations;

namespace Arthes.DATA.Models
{
    public class ModelBase<T> where T : class
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime DataInclusao { get; set; }

        public DateTime? DataAlteracao { get; set; }
    }
}
