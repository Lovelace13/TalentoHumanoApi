using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBEmpresa.Models
{
    public class Empleado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpleadoID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaContratacion { get; set; }
        public int DepartamentoID { get; set; }
        [ForeignKey("DepartamentoID")]
        public Departamento Departamento { get; set; }
        public int SubdepartamentoID { get; set; }
        [ForeignKey("SubdepartamentoID")]
        public SubDepartamento Subdepartamento { get; set; }
        public int RolID { get; set; }
        [ForeignKey("RolID")]
        public RolEmpleado RolEmpleado { get; set; }
    }
}
