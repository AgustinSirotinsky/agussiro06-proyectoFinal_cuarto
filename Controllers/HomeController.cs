﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using agussiro06_tp9.Models;

namespace agussiro06_tp9.Controllers;

public class HomeController : Controller
{
    private IWebHostEnvironment Enviroment;

    public HomeController(IWebHostEnvironment Envirmoent)
    {
        Enviroment=Envirmoent;
    }

    public IActionResult Index()
    {
        ViewBag.Juegos=BD.ListarJuegos();
        ViewBag.Consolas=BD.ListarConsolas();
        return View();
    }
    public IActionResult Usuario()
    {
        ViewBag.JuegoFavorito=BD.DetalleFavorito();
        ViewBag.Usuario=BD.TraerUsuario();
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
    public IActionResult AgregarConsola()
    {
        return View();
    }
    public IActionResult GuardarConsola(Consola Consola, IFormFile myFile)
    {
        System.Console.WriteLine("Peso del archivo: " + myFile.Length);
        if(myFile.Length>0)
        {
            string wwwRootLocal = this.Enviroment.ContentRootPath + @"\wwwroot\FotoConsola\" + myFile.FileName;
            using (var stream = System.IO.File.Create(wwwRootLocal))
            {
                myFile.CopyToAsync(stream);
            }
            Consola.Portada=myFile.FileName;
        }
        BD.AgregarConsola(Consola);
        ViewBag.Juegos=BD.ListarJuegos();
        ViewBag.Consolas=BD.ListarConsolas();
        System.Console.WriteLine("llego y deberia andar pero no anda bueno ahora si anda no se que hice pero anda gracias dios adonai alojam melej aleinu");
        return View("index");
    }
    public IActionResult AgregarJuego()
        {
            ViewBag.Consolas=BD.ListarConsolas();
            return View();
        }
    public IActionResult GuardarJuego(Juego Juego, IFormFile myfile)
    {
         if(myfile.Length>0)
        {
            System.Console.WriteLine("llego algo");
            string wwwRootLocal = this.Enviroment.ContentRootPath + @"\wwwroot\FotoJuego\" + myfile.FileName;
            System.IO.File.Delete(wwwRootLocal);
            using (var stream = System.IO.File.Create(wwwRootLocal))
            {
                myfile.CopyToAsync(stream);
            }
            Juego.Portada=myfile.FileName;
        }
        BD.AgregarJuego(Juego);
        ViewBag.Juegos=BD.ListarJuegos();
        ViewBag.Consolas=BD.ListarConsolas();
        return View("index");
    }
    public IActionResult AgregarFavorito(int idJuego)
    {
        BD.AgregarFavorito(idJuego);
        ViewBag.Juegos=BD.ListarJuegos();
        ViewBag.Consolas=BD.ListarConsolas();
        return View("index");
    }
    public Consola MostrarInformacionAjaxConsola(int _IdConsola)
    {
        return BD.DetalleConsola(_IdConsola);
    }
    public Juego MostrarInformacionAjaxJuego(int _IdJuego)
    {
        return BD.DetalleJuego(_IdJuego);
    }

    public IActionResult BorrarConsola(int idConsola)
    {
        BD.BorrarConsola(idConsola);
        ViewBag.Juegos=BD.ListarJuegos();
        ViewBag.Consolas=BD.ListarConsolas();
        return View("index");
    }
    public IActionResult BorrarJuego(int idJuego)
    {
        BD.BorrarJuego(idJuego);
        ViewBag.Juegos=BD.ListarJuegos();
        ViewBag.Consolas=BD.ListarConsolas();
        return View("index");
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
