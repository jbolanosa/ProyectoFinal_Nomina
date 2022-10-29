using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Nomina> Nomina { get; set; }
        public DbSet<Puesto> Puesto { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
