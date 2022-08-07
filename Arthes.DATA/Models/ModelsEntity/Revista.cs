
using Arthes.DATA.Enums;

namespace Arthes.DATA.Models.ModelsEntity;

public partial class Revista
{
    public Revista()
    {
        Receita = new HashSet<Receita>();
    }

    public int Id { get; set; }
    public string Tema { get; set; }
    public int NumeroEdicao { get; set; }
    public Mes MesEdicao { get; set; }
    public string AnoEdicao { get; set; }

    public virtual ICollection<Receita> Receita { get; set; }
}