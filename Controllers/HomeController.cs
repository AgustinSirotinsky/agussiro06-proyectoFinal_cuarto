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
        ViewBag.Consolas=BD.ListarConsolas();
        return View();
    }
    public Consola MostrarInformacionAjax(string _NombreConsola)
        {
            return BD.DetalleConsola(_NombreConsola);
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
