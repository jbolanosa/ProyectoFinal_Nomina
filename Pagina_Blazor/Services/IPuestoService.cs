using Pagina_Blazor.Models;

namespace Pagina_Blazor.Services
{
    public interface IPuestoService
    {
        Task<HttpResponseMessage> PostPuesto(Puesto puesto);
        Task<Puesto> GetPuesto(int id);
        Task<List<Puesto>> GetPuesto();
        Task<HttpResponseMessage> PutPuesto(int id, Puesto puesto);

    }
}
