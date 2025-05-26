using ArtDealer2.Data;

namespace ArtDealer2.Repositorio
{
    public interface IRepositorioObras
    {
        Task<List<Obra>> GetAll();
        Task<Obra> Get(int id);
        Task Add(Obra obra);
        Task Update(Obra obra);
        Task Delete(int id);
    }
}
