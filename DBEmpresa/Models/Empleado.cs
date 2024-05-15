using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBEmpresa.Models
{
    public class Empleado
    {
        public int EmpleadoID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaContratacion { get; set; }
        public int DepartamentoID { get; set; }
        public Departamento Departamento { get; set; }
        public int SubdepartamentoID { get; set; }
        public SubDepartamento Subdepartamento { get; set; }
        public int RolID { get; set; }
        public RolEmpleado RolEmpleado { get; set; }
    }
}
