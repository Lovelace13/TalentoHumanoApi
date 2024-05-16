using DBEmpresa;
using DBEmpresa.DTOs;
using DBEmpresa.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TalentoHumanoApi.Controllers
{
    [Route("NTS/[controller]")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        private NTSContext _context;

        public EmpleadosController(NTSContext context)
        {
            _context = context;
        }

        [Route("ListaEmpleados")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Empleado>>> GetEmpleados()
        {
            return await _context.Empleados.ToListAsync();
        }


        [Route("ObtenerEmpleado")]
        [HttpGet]
        public async Task<ActionResult<Empleado>> GetEmpleado(int id)
        {
            var empleado = await _context.Empleados.FindAsync(id);

            if (empleado == null)
            {
                return NotFound();
            }

            return empleado;
        }

        [Route("NuevoEmpleado")]
        [HttpPost]
        public async Task<ActionResult<Empleado>> CrearEmpleado(EmpleadoDto empleado)
        {
            var newEmployee = new Empleado
            {
                Nombre = empleado.Nombre,
                Apellido = empleado.Apellido,
                FechaContratacion = empleado.FechaContratacion,
                DepartamentoID = empleado.DepartamentoID,
                SubDepartamentoID = empleado.SubdepartamentoID,
                RolEmpleadoID = empleado.RolID
            };
            _context.Empleados.Add(newEmployee);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmpleado", new { id = newEmployee.EmpleadoID }, newEmployee);
        }

        [Route("ModificarEmpleado")]
        [HttpPut]
        public async Task<IActionResult> PutEmpleado(int id, Empleado empleado)
        {
            if (id != empleado.EmpleadoID)
            {
                return BadRequest();
            }

            _context.Entry(empleado).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpleadoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [Route("EliminarEmpleado")]
        [HttpDelete]
        public async Task<IActionResult> DeleteEmpleado(int id)
        {
            var empleado = await _context.Empleados.FindAsync(id);
            if (empleado == null)
            {
                return NotFound();
            }

            _context.Empleados.Remove(empleado);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmpleadoExists(int id)
        {
            return _context.Empleados.Any(e => e.EmpleadoID == id);
        }
    }
}
