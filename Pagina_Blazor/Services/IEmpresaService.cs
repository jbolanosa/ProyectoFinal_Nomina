using Pagina_Blazor.Models;

namespace Pagina_Blazor.Services
{
    public interface IEmpresaService
    {
        Task<Empresa> GetEmpresa(int id);
    }
}
