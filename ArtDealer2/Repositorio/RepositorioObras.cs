using ArtDealer2.Data;
using Microsoft.EntityFrameworkCore;

namespace ArtDealer2.Repositorio
{
    public class RepositorioObras :IRepositorioObras
    {
        private readonly BDArtDealerContext _context;

        public RepositorioObras(BDArtDealerContext context)
        {
            _context = context;
        }

        public async Task Add(Obra obra)
        {
            await _context.Obras.AddAsync(obra);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var obra = await _context.Obras.FindAsync(id);
            _context.Obras.Remove(obra!);
            await _context.SaveChangesAsync();
        }

        public async Task<Obra> Get(int id)
        {
            return await _context.Obras.Include(_ => _.Artista).FirstAsync(_ => _.Id == id);
        }

        public async Task<List<Obra>> GetAll()
        {
            return await _context.Obras.Include(_ => _.Artista).AsNoTracking().ToListAsync();
        }

        public async Task Update(Obra obra)
        {
            _context.Obras.Update(obra);
            await _context.SaveChangesAsync();
        }

    }
}
