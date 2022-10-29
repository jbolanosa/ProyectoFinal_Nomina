using Pagina_Blazor.Models;

namespace Pagina_Blazor.Services
{
    public interface INominaService
    {
        Task<HttpResponseMessage> PostNomina(Nomina nomina);
        Task<List<Nomina>> GetNominaFiltrado(int mes, int anio);
    }
}
