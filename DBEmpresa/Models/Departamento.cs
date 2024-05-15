using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBEmpresa.Models
{
    public class Departamento
    {
        public int DepartamentoID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public ICollection<SubDepartamento> Subdepartamentos { get; set; }
        public ICollection<Empleado> Empleados { get; set; }
    }
}
