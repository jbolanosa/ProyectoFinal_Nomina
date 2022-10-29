using Pagina_Blazor.Models;
namespace Pagina_Blazor.Services
{
    public interface IEmpleadoService
    {
        Task<Empleado> GetEmpleado(int id);
        Task<HttpResponseMessage> PostEmpleado(Empleado empleado);
        Task<List<Empleado>> GetEmpleado();
        Task<HttpResponseMessage> PutEmpleado(int id, Empleado empleado);
    }
}
