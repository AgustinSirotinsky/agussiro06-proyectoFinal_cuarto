using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using agussiro06_tp9.Models;

namespace agussiro06_tp9.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Juegos=BD.ListarJuegos();
        ViewBag.Consolas=BD.ListarConsolas();
        return View();
    }
    public IActionResult DetalleJuego(int IdJuego)
    {
        ViewBag.DetalleJuego=BD.DetalleJuego(IdJuego);
        return View();
    }
    public IActionResult DetalleConsola(int IdConsola)
    {
        ViewBag.Juegos=BD.ListarJuegosEspecificos(IdConsola);
        ViewBag.DetalleConsola=BD.DetalleConsola(IdConsola);
        return View();
    }
    public Consola MostrarInformacionAjaxConsola(int _IdConsola)
    {
        return BD.DetalleConsola(_IdConsola);
    }
    public Juego MostrarInformacionAjaxJuego(int _IdJuego)
    {
        return BD.DetalleJuego(_IdJuego);
    }

    public IActionResult Minijuego()
    {
        return View();
    }
    public IActionResult Usuario()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
