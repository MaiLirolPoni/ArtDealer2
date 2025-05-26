using ArtDealer2.Data;
using Microsoft.EntityFrameworkCore;

namespace ArtDealer2.Repositorio
{
    public class RepositorioComisiones : IRepositorioComisiones
    {

        private readonly BDArtDealerContext _context;

        public RepositorioComisiones(BDArtDealerContext context)
        {
            _context = context;
        }

        public async Task Add(Comision comision)
        {
            await _context.Comisiones.AddAsync(comision);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var comision = await _context.Comisiones.FindAsync(id);
            _context.Comisiones.Remove(comision!);
            await _context.SaveChangesAsync();
        }

        public async Task<Comision> Get(int id)
        {
            return await _context.Comisiones.FindAsync(id);
        }

        public async Task<List<Comision>> GetAll()
        {
            return await _context.Comisiones.Include(_ => _.Obra)
                                            .Include(_ => _.Artista).AsNoTracking().ToListAsync();
        }

        public async Task Update(Comision comision)
        {
            _context.Comisiones.Update(comision);
            await _context.SaveChangesAsync();
        }

    }
}
