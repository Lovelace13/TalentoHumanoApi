using DBEmpresa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBEmpresa.DTOs
{
    public class EmpleadoDto
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaContratacion { get; set; }
        public int DepartamentoID { get; set; }

        public int SubdepartamentoID { get; set; }

        public int RolID { get; set; }

    }
}
