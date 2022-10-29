using Pagina_Blazor.Models;
using System.Net.Http.Json;

namespace Pagina_Blazor.Services
{
    public class EmpleadoService : IEmpleadoService
    {
        private readonly HttpClient _httpClient;
        public EmpleadoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Empleado> GetEmpleado(int id)
        {
            return await _httpClient.GetFromJsonAsync<Empleado>($"api/v1/Empleado/{id}");
        }
        public async Task<HttpResponseMessage> PostEmpleado(Empleado empleado)
        {
            return await _httpClient.PostAsJsonAsync<Empleado>("api/v1/Empleado", empleado);
        }
        public async Task<List<Empleado>> GetEmpleado()
        {
            return await _httpClient.GetFromJsonAsync<List<Empleado>>("api/v1/Empleado");
        }

        public async Task<HttpResponseMessage> PutEmpleado(int id, Empleado empleado)
        {
            return await _httpClient.PutAsJsonAsync<Empleado>($"api/v1/Empleado/{id}", empleado);
        }
    }
}
