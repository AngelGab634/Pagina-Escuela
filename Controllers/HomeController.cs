using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Aplicacion1.Models;

namespace Aplicacion1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

     public IActionResult ListaEstudiantes()
    {
        Estudiante alumno = new Estudiante();
        alumno.Nombre = "Angel Gabriel";
        alumno.Carrera = "Ingeniera en tecnologias de la informacion";
        
        return View(alumno);
    }

    public IActionResult ListaProfesores()
    {
        Profesor Maestro = new Profesor();
        Maestro.Nombre = "Ricardo Arturo";
        Maestro.Carrera = "POO II";
        return View(Maestro);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

   public IActionResult ListaGrados()
    {
        Grados materia = new Grados();
        materia.Nombre = "Matematicas";
        materia.Profe ="Luis";
        return View(materia);
    }
}
