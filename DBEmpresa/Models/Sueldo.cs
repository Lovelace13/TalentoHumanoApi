using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBEmpresa.Models
{
    public class Sueldo
    {
        public int SueldoID { get; set; }
        public int EmpleadoID { get; set; }
        public Empleado Empleado { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
    }
}
