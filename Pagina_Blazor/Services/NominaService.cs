using Pagina_Blazor.Models;
using System.Net.Http.Json;

namespace Pagina_Blazor.Services
{
    public class NominaService : INominaService
    {
        private HttpClient _httpClient;
        public NominaService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Nomina>> GetNominaFiltrado(int mes, int anio)
        {
            return await _httpClient.GetFromJsonAsync<List<Nomina>>($"api/v1/Nomina/Periodo?Mes={mes}&Anio={anio}");
        }

        public async Task<HttpResponseMessage> PostNomina (Nomina nomina)
        {
            return await _httpClient.PostAsJsonAsync<Nomina>("api/v1/Nomina", nomina);
        }
    }
}
