using Pagina_Blazor.Models;
using System.Net.Http.Json;

namespace Pagina_Blazor.Services
{
    public class PuestoService : IPuestoService
    {
        private readonly HttpClient _httpClient;
        public PuestoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> PostPuesto(Puesto puesto)
        {
            return await _httpClient.PostAsJsonAsync<Puesto>("api/v1/Puesto", puesto);
        }

        public async Task<Puesto> GetPuesto(int id)
        {
            return await _httpClient.GetFromJsonAsync<Puesto>($"api/v1/Puesto/{id}");
        }

        public async Task<List<Puesto>> GetPuesto()
        {
            return await _httpClient.GetFromJsonAsync<List<Puesto>>("api/v1/Puesto");
        }

        public async Task<HttpResponseMessage> PutPuesto(int id, Puesto puesto)
        {
            return await _httpClient.PutAsJsonAsync<Puesto>($"api/v1/Puesto/{id}", puesto);
        }
    }
}
