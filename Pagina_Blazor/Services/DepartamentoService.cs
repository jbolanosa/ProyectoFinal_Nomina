using Pagina_Blazor.Models;
using System.Net.Http.Json;

namespace Pagina_Blazor.Services
{

    public class DepartamentoService : IDepartamentoService
    {
        private readonly HttpClient _httpClient;

        public DepartamentoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> PostDepartamento(Departamento departamento)
        {
            return await _httpClient.PostAsJsonAsync<Departamento>("api/v1/Departamento", departamento);
        }

        public async Task<List<Departamento>> GetDepartamento()
        {
            return await _httpClient.GetFromJsonAsync<List<Departamento>>("api/v1/Departamento");
        }

        public async Task<Departamento> GetDepartamento(int id)
        {
            return await _httpClient.GetFromJsonAsync<Departamento>($"api/v1/Departamento/{id}");
        }

        public async Task<HttpResponseMessage> PutDepartamento(int id, Departamento departamento)
        {
            return await _httpClient.PutAsJsonAsync<Departamento>($"api/v1/Departamento/{id}", departamento);
        }
    }
}
