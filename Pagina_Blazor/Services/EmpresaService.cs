using Pagina_Blazor.Models;
using System.Net.Http.Json;

namespace Pagina_Blazor.Services
{
    public class EmpresaService : IEmpresaService
    {
        private readonly HttpClient _httpClient;
        public EmpresaService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Empresa> GetEmpresa(int id)
        {
            return await _httpClient.GetFromJsonAsync<Empresa>($"api/v1/Empresa/{id}");
        }
    }
}
