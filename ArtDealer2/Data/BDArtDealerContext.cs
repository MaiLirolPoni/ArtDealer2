using Microsoft.EntityFrameworkCore;

namespace ArtDealer2.Data
{
    public class BDArtDealerContext:DbContext
    {
        public BDArtDealerContext(
                      DbContextOptions<BDArtDealerContext> options
                                    ) : base(options)
        {

        }

        public DbSet<Artista> Artistas{ get; set; }
        public DbSet<Obra> Obras{ get; set; }
        public DbSet<Comision> Comisiones { get; set; }
    }
}
