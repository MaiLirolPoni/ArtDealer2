using ArtDealer2.Data;

namespace ArtDealer2.Repositorio
{
    public interface IRepositorioArtistas
    {
        Task<List<Artista>> GetAll();
        Task<Artista> Get(int id);
        Task Add(Artista artista);
        Task Update(Artista artista);
        Task Delete(int id);

        
    }
}
