using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBEmpresa.Models
{
    public class RolEmpleado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RolEmpleadoID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        //public ICollection<Empleado> Empleados { get; set; }
    }
}
