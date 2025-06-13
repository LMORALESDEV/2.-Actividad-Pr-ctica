using Actividad3LengPro3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Actividad3LengPro3.Controllers
{
    public class EstudiantesController : Controller
    {
        public IActionResult Index() 
        {
            return View();
        }
        
            private static List<EstudiantesViewModel> estudiantes = new List<EstudiantesViewModel>();

        // GET: Estudiantes
        [HttpGet]
        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(EstudiantesViewModel model)
        {
            if (estudiante.EstaBecado == false)
            {
                estudiante.PorcentajeBeca = null;
            }

            if (ModelState.IsValid)
            {
                ViewBag.Message = "El estudiante ha sido registrado.";
                return View(model);
            }
            return View(model);
        }

        public ActionResult Lista()
        {
            return View(estudiantes);
        }

        public ActionResult Editar(string matricula)
        {
            var estudiante = estudiantes.FirstOrDefault(e => e.Matricula == matricula);
            if (estudiante == null)
                return View();

            return View(estudiante);
        }

        [HttpPost]
        public ActionResult Editar(EstudiantesViewModel estudiante)
        {
            if (ModelState.IsValid)
            {
                var existente = estudiantes.FirstOrDefault(e => e.Matricula == estudiante.Matricula);
                if (existente != null)
                {
                    estudiantes.Remove(existente);
                    estudiantes.Add(estudiante);
                }
                return RedirectToAction("Lista");
            }

            return View(estudiante);
        }

        public ActionResult Eliminar(string matricula)
        {
            var estudiante = estudiantes.FirstOrDefault(e => e.Matricula == matricula);
            if (estudiante != null)
            {
                estudiantes.Remove(estudiante);
            }
            return RedirectToAction("Lista");
        }
    }


    }

