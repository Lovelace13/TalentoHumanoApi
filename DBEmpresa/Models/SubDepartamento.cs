using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBEmpresa.Models
{
    public class SubDepartamento
    {
        public int SubdepartamentoID { get; set; }
        public string Nombre { get; set; }
        public int DepartamentoID { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<Empleado> Empleados { get; set; }
    }
}
