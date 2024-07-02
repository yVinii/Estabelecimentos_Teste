using EstabelecimentoMaggi.Models;
using Microsoft.EntityFrameworkCore;

namespace EstabelecimentoMaggi.Data
{
    public class BancoContext : DbContext
    {

        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<EstabelecimentoModel> Estabelecimentos { get; set; }

    }
}
