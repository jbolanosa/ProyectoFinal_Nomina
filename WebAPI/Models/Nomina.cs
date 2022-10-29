using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public class Nomina
    {
        public int NominaId { get; set; }
        [Column(TypeName = "numeric(2)")]
        public int Mes { get; set; }
        [Column(TypeName = "numeric(4)")]
        public int Anio { get; set; }
        public DateTime PeriodoLiquidacionInicial { get; set; }
        public DateTime PeriodoLiquidacionFinal { get; set; }
        public int DiasLaborados { get; set; }
        public double SueldoBase { get; set; }  
        public int? HorasExtras { get; set; }
        public double? TotalHorasExtras { get; set; }
        public double? BonificacionIncentivo { get; set; }
        public double? IGSS { get; set; }
        public double? IRTRA { get; set; }
        public double? Intecap { get; set; }
        public double? SueldoLiquido { get; set; }

        public int? EmpleadoId { get; set; }
        public Empleado? Empleado { get; set; }


    }
}
