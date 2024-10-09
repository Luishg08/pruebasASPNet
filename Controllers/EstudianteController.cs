using Microsoft.AspNetCore.Mvc;
using MiAppWeb.Data;
using MiPrimeraWeb.Models; // Asegúrate de que este espacio de nombres sea correcto

namespace MiPrimeraWeb.Controllers;
    [Route("[controller]")]
    [ApiController]
    public class EstudiantesController : Controller
    {
        private readonly ApplicationDbContext _context;

        // Constructor
        public EstudiantesController(ApplicationDbContext context)
        {
            _context = context;     
        }

        // Métodos de acción
        [HttpGet]
        public ActionResult Get()
        {
            return Ok("Estudiantes");
        }

         [HttpPost]
        public ActionResult<ModeloEstudiante> CrearEstudiante(ModeloEstudiante estudiante)
        {
            _context.Estudiantes.Add(estudiante);
            _context.SaveChanges();
            return Ok(estudiante);
        }
    }