using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Arthes.DATA.Models
{
    public class ModelBase<T> where T : class
    {
        public int Id { get; set; }
    }
}
