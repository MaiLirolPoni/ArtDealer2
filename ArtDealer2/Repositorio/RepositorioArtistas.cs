using ArtDealer2.Data;
using Microsoft.EntityFrameworkCore;

namespace ArtDealer2.Repositorio
{
    public class RepositorioArtistas : IRepositorioArtistas
    {
        private readonly BDArtDealerContext _context;

        public RepositorioArtistas(BDArtDealerContext context)
        {
            _context = context;
        }

        public async Task Add(Artista artista)
        {
            await _context.Artistas.AddAsync(artista);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var artista= await _context.Artistas.FindAsync(id);
            _context.Artistas.Remove(artista!);
            await _context.SaveChangesAsync();
        }

        public async Task<Artista> Get(int id)
        {
            return await _context.Artistas.Include(_ => _.Obras).FirstAsync(_ => _.Id == id);
        }

        public async Task<List<Artista>> GetAll()
        {
            return await _context.Artistas.Include(_ => _.Obras)
                                          .AsNoTracking().ToListAsync();
        }

        public async Task Update(Artista artista)
        {
            _context.Artistas.Update(artista);
            await _context.SaveChangesAsync();
        }



    }
}
