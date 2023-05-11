using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TpIndumentaria.Models;

namespace TpIndumentaria.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.DicEquipos = Equipo.DicEquipos;
        return View(Index);
        
    }

    public IActionResult SelectIndumentaria()
    {
        ViewBag.Equipos = Equipo.ListEquipos;
        ViewBag.Camiseta = Equipo.ListCamiseta;
        ViewBag.Medias = Equipo.ListMedias;
        ViewBag.Pantalones = Equipo.ListPantalon;
        return View(SelectIndumentaria);
    }
    public IActionResult GuardarIndumentaria(int Equipo,int Media,int Pantalon,int Remera){
if (Equipo == 0 || Media == 0 || Pantalon == 0 || Remera == 0) s
    {
        ViewBag.Error = "Por favor seleccione una opción para cada campo."; 
        return View("SelectIndumentaria");
    }else
    {
      return View("SelectIndumentaria");
    }
    }
    }