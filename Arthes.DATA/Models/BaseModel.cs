namespace Arthes.DATA.Models
{
    public class BaseModel<T> where T : class
    {
        public int Id { get; set; }

        public DateTime DataInclusao { get; set; }
    }
}
