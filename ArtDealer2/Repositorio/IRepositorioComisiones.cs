using ArtDealer2.Data;

namespace ArtDealer2.Repositorio
{
    public interface IRepositorioComisiones
    {
        Task<List<Comision>> GetAll();
        Task<Comision> Get(int id);
        Task Add(Comision comision);
        Task Update(Comision comision);
        Task Delete(int id);
    }
}
