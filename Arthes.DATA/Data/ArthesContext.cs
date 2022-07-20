using Arthes.DATA.Models;

using Microsoft.EntityFrameworkCore;

namespace Arthes.DATA.Data
{
    public class ArthesContext : DbContext
    {
        public ArthesContext(DbContextOptions<ArthesContext> options) : base(options)
        {

        }

        public virtual DbSet<RevistaModel> REVISTAS { get; set; }
    }
}
